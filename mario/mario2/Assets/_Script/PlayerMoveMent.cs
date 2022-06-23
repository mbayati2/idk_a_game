using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;
using Cinemachine;


#if UNITY_EDITOR
using UnityEditor;
#endif
public class PlayerMoveMent : MonoBehaviour
{
    public float MoveSpeedAmount;
    public float JumpHiehtAmount;
    public float FeetRaidus;
    [HideInInspector] public float JumpTimerCounter;
    public int JumpDone;
    public Vector2 Inputs;
    public float JumpTime;
    public float valueTime;    
    public float coyotiJump = 0.4f;
    public float JumpBufferTime = 0.4f;
    public int JumpAmount;
    public bool Grounded;
    public bool Jumping;
    public LayerMask JumpAble;
    public Transform Feet;
    public Rigidbody2D rb;
    public CinemachineVirtualCamera cinemachine;
    public PlayerMoveMentState state;
    public NormalMoveMent normalMoveMent = new NormalMoveMent();
    bool boolisrunnig;

    public void ChangeState(PlayerMoveMentState newstate)
    {
        state = newstate;

        state.OnStart(this);
    }
    
    private void FixedUpdate() 
    {
        Inputs.x = Input.GetAxisRaw("Horizontal");
        Inputs.y = Input.GetAxisRaw("Vertical");
        state.OnFixedUpdate(this);
    }

    private void Update()
    {
        state.OnUpdate(this);

        Grounded = Physics2D.OverlapCircle(Feet.position , FeetRaidus , JumpAble);
    }


    private void Start() {
        state = normalMoveMent;
        state.OnStart(this);
    }


    #if UNITY_EDITOR

    private void OnDrawGizmosSelected() {
        Handles.DrawWireDisc(Feet.position , transform.forward , FeetRaidus);

    }

    #endif
    
}
