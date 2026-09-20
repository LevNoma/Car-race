using UnityEngine;

public class UiInstaller : MonoBehaviour
{
    private SpeedPresenter _speedPresenter;
    private TimerPresenter _timerPresenter;
    [SerializeField]private SpeedView _speedView;
    [SerializeField]private TimerView _timerView;
    [SerializeField]private CarControler _carControler;

    private void Start()
    {
        _speedPresenter = new SpeedPresenter(_speedView, _carControler);
        _timerPresenter = new TimerPresenter(_timerView);
    }
}
