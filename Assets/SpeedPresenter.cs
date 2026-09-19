using System.Collections;
using UnityEngine;

public class SpeedPresenter
{
    private readonly SpeedView _speedView;
    private readonly CarControler _car;
    public SpeedPresenter(SpeedView speedView, CarControler car)
    {
        _speedView = speedView;
        _car = car;
       _speedView.StartCoroutine(UpdateSpeed());
    }

    public IEnumerator UpdateSpeed()
    {
        while (true)
        {
            _speedView.UpdateSpeedText((int)_car.GetSpeed());
            yield return new WaitForFixedUpdate();
        }
    }
}