using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Animator capAnim;

    private enum State{
        Idle, Hit, HitDead, DeadGround
    }

    public int capHp = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        State state = State.Idle;
        if(Input.GetMouseButtonDown(0))
        {
            state = State.Hit;
            capHp -= 1;
        }
        this.capAnim.SetInteger("CaptainState", (int)state);

    }
}
