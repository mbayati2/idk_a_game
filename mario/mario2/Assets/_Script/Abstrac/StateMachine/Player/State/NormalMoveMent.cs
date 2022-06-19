using UnityEngine;
using Cinemachine;
using System.Collections;
using System.Collections.Generic;

public class NormalMoveMent : PlayerMoveMentState 
{
    private CinemachineTransposer offset;
    float nomaleValue = 2.17f;
    float LookYDir;

    public override void OnStart(PlayerMoveMent player)
    {
       offset = player.cinemachine.GetCinemachineComponent<CinemachineTransposer>();
    }
    public override void OnUpdate(PlayerMoveMent player)
    {
        JUMPWA(player);

        
        Jumpo(player);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            player.Jumping = false;
        }    

        LookDir(player);
    }

    private void LookDir(PlayerMoveMent player)
    {
        float Amount = new float();
        
        Amount = DirAmount();
        


        offset.m_FollowOffset.y = Mathf.Lerp(offset.m_FollowOffset.y , Amount , player.valueTime * Time.deltaTime);
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
        float moveDir = Input.GetAxisRaw("Horizontal");
        LookYDir = Input.GetAxisRaw("Vertical");




        player.rb.velocity = new Vector2(moveDir * player.MoveSpeedAmount , player.rb.velocity.y);
    }

    private void JUMPWA(PlayerMoveMent player)
    {
        
        if (player.JumpAmount == player.JumpDone) { if (player.Grounded == false) { return; } }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Jumping = true;
            player.rb.velocity = Vector2.up * player.JumpHiehtAmount;
            player.JumpDone++;
            if (player.Grounded == true)
            {
                player.JumpTimerCounter = player.JumpTime;
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