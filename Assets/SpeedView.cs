using TMPro;
using UnityEngine;

public class SpeedView : MonoBehaviour
{
    private TextMeshProUGUI _speedText;

    private void Awake()
    {
        _speedText = GetComponent<TextMeshProUGUI>();
    }
    public void UpdateSpeedText(int speed)
    {
        _speedText.text = $"{speed} km/h";
    }
}
