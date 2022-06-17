using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class PlayerMoveMent : MonoBehaviour
{
    public float MoveSpeedAmount;
    public float JumpHiehtAmount;
    public float FeetRaidus;
    [HideInInspector] public float JumpTimerCounter;
    [HideInInspector] public int JumpDone;
    public float JumpTime;
    public int JumpAmount;
    public int DelayAmountOnJump;
    public bool Grounded;
    public bool Jumping;
    public LayerMask JumpAble;
    public Transform Feet;
    public Rigidbody2D rb;

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
        state.OnFixedUpdate(this);
    }

    private void Update()
    {
        state.OnUpdate(this);

        bool owo = Physics2D.OverlapCircle(Feet.position , FeetRaidus , JumpAble);
        if (owo == false)
        {
            AddExera();
            return;
        } 
        Grounded = true;
    }

    private async void AddExera()
    {
        if (JumpDone > 0) { Grounded = false; return; }
        if (boolisrunnig == true) { return; }

        boolisrunnig = true;

        await Task.Delay(DelayAmountOnJump);


        Grounded = Physics2D.OverlapCircle(Feet.position , FeetRaidus , JumpAble);
        boolisrunnig = false;
    }

    private void Start() {
        state = normalMoveMent;
    }


    #if UNITY_EDITOR

    private void OnDrawGizmosSelected() {
        Handles.DrawWireDisc(Feet.position , transform.forward , FeetRaidus);
    }

    #endif
}
