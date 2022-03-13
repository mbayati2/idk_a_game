using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent = null;
    [SerializeField] AnimationCurve plot = new AnimationCurve();
    public Animator anim;

    float motionSmoothTime = .1f;
    void Start()
    {
        agent = Player_holder.player_Holder.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (agent == null) { agent = Player_holder.player_Holder.Local_player.GetComponent<NavMeshAgent>(); }
        float speed = agent.velocity.magnitude / agent.speed;
        plot.AddKey(Time.realtimeSinceStartup , speed);
        anim.SetFloat("Blend", speed, motionSmoothTime, Time.deltaTime);
    }
}
