using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Animator capAnim;

    private enum State
    {
        Idle, Hit, HitDead, DeadGround
    }
    private State state = State.Idle;

    public int capHp = 2;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (capHp > 0)
        {
            state = State.Idle;
            this.capAnim.SetInteger("CaptainState", (int)state);
        }

        if (Input.GetMouseButtonDown(0))
        {
            state = State.Hit;
            capHp -= 1;
            if(capHp == 0)
            {
                state = State.HitDead;
            }
            this.capAnim.SetInteger("CaptainState", (int)state);
        }
        
        Debug.Log(capHp);

        if (capHp <= 0)
        {
            state = State.DeadGround;
            this.capAnim.SetInteger("CaptainState", (int)state);
        }
    }
}
