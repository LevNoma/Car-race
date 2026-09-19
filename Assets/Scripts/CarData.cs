using UnityEngine;

[CreateAssetMenu(fileName = "CarData", menuName = "Scriptable Objects/CarData")]
public class CarData : ScriptableObject
{
    [SerializeField] private int _maxSpeed;
    public int MaxSpeed { get { return _maxSpeed; }}

    [SerializeField] private int _acceleration;
    public int Acceleration { get { return _acceleration; } }

    [SerializeField] private int _stopSpeed;
    public int StopSpeed { get { return _stopSpeed; } }

    [SerializeField] private int _maxReversedSpeed;
    public int MaxReversedSpeed { get { return _maxReversedSpeed; } }

    [SerializeField] private int _rotatePower;
    public int RotatePower { get { return _rotatePower; } }
}
