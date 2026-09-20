using System.Collections;
using UnityEngine;

public class TimerPresenter
{
    private readonly TimerView _timerView;
    public TimerPresenter(TimerView timerView)
    {
        _timerView = timerView;
        _timerView.StartCoroutine(StartTimer());
    }


    private IEnumerator StartTimer()
    {
        float time = Time.timeSinceLevelLoad;
        while (true)
        {
            time += Time.deltaTime;
            _timerView.UpdateTimer(time);
            yield return null;
        }
    }
}
