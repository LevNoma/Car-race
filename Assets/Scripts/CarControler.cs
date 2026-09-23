using UnityEngine;

public class CarControler : MonoBehaviour
{
    [SerializeField] private CarData _carData;
    [SerializeField] private CheckPointControler _checkPointControler;

    private int _currentCheckPoint = 0;
    private Rigidbody2D _rigidbody2D;

    private Vector2 _lastDirection;
    private Vector2 _Rotatedirection;


    private float _currentSpeed;

    public void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void UpdateDirection(Vector2 direction)
    {
        _lastDirection = direction;
    }

    private void FixedUpdate()
    {
        Drive();
    }

    public float GetSpeed()
    {
        return _rigidbody2D.linearVelocity.magnitude;
    }


    private void Drive()
    {
        Vector2 direction = transform.right * _lastDirection.y;

        _rigidbody2D.AddForce(direction * _carData.Acceleration * Time.fixedDeltaTime, ForceMode2D.Force);

        float currentMaxSpeed = _lastDirection.y >= 0 ? _carData.MaxSpeed : _carData.MaxReversedSpeed;

        if (_rigidbody2D.linearVelocity.magnitude > currentMaxSpeed)
        {
            _rigidbody2D.linearVelocity = _rigidbody2D.linearVelocity.normalized * currentMaxSpeed;
        }



       _rigidbody2D.AddTorque(-_lastDirection.x * _carData.RotatePower * Time.fixedDeltaTime, ForceMode2D.Force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Checkpoint>().IsPassed == false)
        {
            collision.gameObject.GetComponent<Checkpoint>().IsPassed = true;
            _currentCheckPoint++;
            Debug.Log("Checkpoint");

            if (_currentCheckPoint >= _checkPointControler._checkPointNumber)
            {
                _checkPointControler.UpdateAllCheckPoints();
                Debug.Log("Level Completed");
            }
        }
    }
}
