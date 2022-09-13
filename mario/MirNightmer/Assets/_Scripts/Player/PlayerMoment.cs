using UnityEngine;

public class PlayerMoment : MonoBehaviour {
    
    [SerializeField] private RigidBody2d body2D;
    float MovementX;
    float MovementY;
    
    public void OnPlayerMoveButtomDown()
    {

        MovementX;
        MovementY;

    }

    private void Update() {
        
        body2D.verlocity = new Vector2(MovementX , MovementY).normalized;

    }

}