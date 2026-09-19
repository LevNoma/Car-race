using UnityEngine;

public class UiInstaller : MonoBehaviour
{
    private SpeedPresenter _speedPresenter;
    [SerializeField]private SpeedView _speedView;
    [SerializeField]private CarControler _carControler;

    private void Start()
    {
        _speedPresenter = new SpeedPresenter(_speedView, _carControler);
    }
}
