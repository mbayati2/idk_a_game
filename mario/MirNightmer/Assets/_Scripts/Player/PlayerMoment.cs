using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoment : MonoBehaviour {
    
    [SerializeField] private Rigidbody2D body2D;
    float MovementX;
    float MovementY;
    
    public void OnPlayerMoveButtomDown(InputAction.CallbackContext callbackContext)
    {

        MovementX = callbackContext.ReadValue<Vector2>().x;
        MovementY = callbackContext.ReadValue<Vector2>().y;

    }

    private void Update() {
        
        body2D.velocity = new Vector2(MovementX , MovementY).normalized;

    }

}