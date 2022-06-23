using UnityEngine;
using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System;

public class NormalMoveMent : PlayerMoveMentState 
{
    private CinemachineFramingTransposer offset;
    float nomaleValue = 2.17f;
    float coyotiJumpCounter;
    float JumpBufferCounter;
    float LookYDir;

    public override void OnStart(PlayerMoveMent player)
    {
       offset = player.cinemachine.GetCinemachineComponent<CinemachineFramingTransposer>();
    }
    public override void OnUpdate(PlayerMoveMent player)
    {
        JUMPWA(player);

        CoyotiJumptFunc(player);
        JumpBufferCounterFunc(player);

        Jumpo(player);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            player.Jumping = false;
            coyotiJumpCounter = 0f;
        }    

        LookDir(player);
    }

    private void JumpBufferCounterFunc(PlayerMoveMent player)
    {
        if (Input.GetButtonDown("Jump"))
        {
            JumpBufferCounter = player.JumpBufferTime;
            return;
        }
        JumpBufferCounter -= Time.deltaTime;
    }

    private void CoyotiJumptFunc(PlayerMoveMent player)
    {
        if (player.Grounded)
        {
            coyotiJumpCounter = player.coyotiJump;
            return;
        }
        coyotiJumpCounter -= Time.deltaTime;
    }

    private void LookDir(PlayerMoveMent player)
    {
        float Amount = new float();
        
        Amount = DirAmount();
        


        offset.m_TrackedObjectOffset.y = Mathf.Lerp(offset.m_TrackedObjectOffset.y , Amount , player.valueTime * Time.deltaTime);
    }

    private float DirAmount()
    {  
        if ((LookYDir * LookYDir) > 0) 
        {

            if (LookYDir > 0) 
            {
                return nomaleValue * 2;
            }

            return -1; 

        }


        return nomaleValue;        
    }

    public override void OnFixedUpdate(PlayerMoveMent player)
    {
        LookYDir = player.Inputs.y;

        player.rb.velocity = new Vector2(player.Inputs.x * player.MoveSpeedAmount , player.rb.velocity.y);
    }

    private void JUMPWA(PlayerMoveMent player)
    {
        if (player.JumpAmount > player.JumpDone) 
        {
            MoreJumps(player);
            return;
        }


        if (JumpBufferCounter > 0f && coyotiJumpCounter > 0)
        {
            player.Jumping = true;
            player.rb.velocity = Vector2.up * player.JumpHiehtAmount;
            player.JumpDone++;
            
            if (player.Grounded == true)
            {
                player.JumpTimerCounter = player.JumpTime;
                JumpBufferCounter = 0f;
                player.JumpDone = 0;
            }
        }


    }

    private void MoreJumps(PlayerMoveMent player)
    {
                
       
        
            if (JumpBufferCounter > 0f)
            {
                player.Jumping = true;
                player.rb.velocity = Vector2.up * player.JumpHiehtAmount;
                player.JumpDone++;
                if (player.Grounded == true)
                {
                    player.JumpTimerCounter = player.JumpTime;
                    JumpBufferCounter = 0f;
                    player.JumpDone = 0;
                }
            }
           
        
    }

    void Jumpo(PlayerMoveMent player)
    {
        if (player.Jumping == false) { return; }


        if (Input.GetKey(KeyCode.Space))
        {
            if (player.JumpTimerCounter > 0) { 
             player.rb.velocity = Vector2.up * player.JumpHiehtAmount;
             player.JumpTimerCounter -= Time.deltaTime;
             return;
            }
            
            player.Jumping = false;
            
  
        }
    }
}