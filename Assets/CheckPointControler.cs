using UnityEngine;

public class CheckPointControler : MonoBehaviour
{
    [SerializeField] private int _howManyCheckPoints;
    public int _checkPointNumber { get { return _howManyCheckPoints; } }

    [SerializeField] private Checkpoint[] _allCheckpoints;
    public void UpdateAllCheckPoints()
    {
        for (int i = 0; i < _allCheckpoints.Length; i++)
        {
            _allCheckpoints[i].IsPassed = false;
        }
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        for (int i = 0; i < _allCheckpoints.Length; i++)
        {
            if (i < _allCheckpoints.Length - 1 && _allCheckpoints[i + 1] != null)
            {
                Gizmos.DrawLine(_allCheckpoints[i].transform.position, _allCheckpoints[i + 1].transform.position);
            }
            else
            {
                Gizmos.DrawLine(_allCheckpoints[i].transform.position, _allCheckpoints[0].transform.position);
            }
        }
    }
}
