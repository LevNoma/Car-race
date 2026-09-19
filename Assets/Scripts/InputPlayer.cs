using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer : MonoBehaviour
{
    private CarControler _carControler;

    private void Start()
    {
        _carControler = GetComponent<CarControler>();
    }

    public void Direction(InputAction.CallbackContext context)
    {
        _carControler.UpdateDirection(context.ReadValue<Vector2>());
    }

    public void GetMousePosition(InputAction.CallbackContext context)//
    {
        
    }
}
