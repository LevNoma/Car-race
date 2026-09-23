using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "Scriptable Objects/LevelData")]
public class LevelData : ScriptableObject
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
}
