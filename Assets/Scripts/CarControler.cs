using UnityEngine;

public class CarControler : MonoBehaviour
{
    [SerializeField] private CarData _carData;


    private Rigidbody2D _rigidbody2D;

    private Vector2 _lastDirection;
    private Vector2 _Rotatedirection;

    private float _currentSpeed;

    public void Start()
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


    private void Drive()
    {
         Vector2 direction = new Vector2(_lastDirection.y, 0);




        _rigidbody2D.AddForce(direction * _carData.Acceleration * 100 * Time.fixedDeltaTime, ForceMode2D.Force);
        _rigidbody2D.linearVelocityX = Mathf.Clamp(_rigidbody2D.linearVelocityX, -_carData.MaxReversedSpeed, _carData.MaxSpeed);





        //  _rigidbody2D.AddTorque(-_lastDirection.x * _carData.RotatePower * Time.fixedDeltaTime, ForceMode2D.Force);
    }
}
