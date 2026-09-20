using TMPro;
using UnityEngine;

public class TimerView : MonoBehaviour
{
    private TextMeshProUGUI _timerText;

    private void Awake()
    {
        _timerText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTimer(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        _timerText.text = $"{minutes:00}:{seconds:00}";
    }
}
