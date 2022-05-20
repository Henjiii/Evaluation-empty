using UnityEngine;
using UnityEngine.InputSystem;

public class SnakeController : MonoBehaviour
{
    public void OnMove(InputAction.CallbackContext context)
    {
        Input.GetButton("stop");


    }

    Vector2 v2 = new Vector2(10, 10);
    Vector2Int v2i;

    Coroutine Move;

    private int timeBeforeMove;

    private bool IsAlive()
    {

    } 
}
