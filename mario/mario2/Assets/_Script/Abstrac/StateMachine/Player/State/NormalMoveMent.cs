using UnityEngine;
using System.Collections;
using System;

public class NormalMoveMent : PlayerMoveMentState 
{

    public override void OnUpdate(PlayerMoveMent player)
    {
        JUMPWA(player);

        
        Jumpo(player);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            player.Jumping = false;
        }    
    }
    public override void OnFixedUpdate(PlayerMoveMent player)
    {
        float moveDir = Input.GetAxisRaw("Horizontal");
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