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
        float time = 0;
        while (true)
        {
            time += Time.deltaTime;
            _timerView.UpdateTimer(time);
            yield return null;
        }
    }
}
