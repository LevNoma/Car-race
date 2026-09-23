using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private bool _isPassed = false;

    public bool IsPassed { get { return _isPassed; } set { _isPassed = value; } }
}
