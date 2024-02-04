using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAController : MonoBehaviour
{
    [SerializeField] Animator anim;
    private int hp = 2;
    private enum State{
        EnemyA, EnemyAHit
    }   
    private State state;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {  
        if (hp == 0)
        {
            Destroy(this.gameObject);
        }
        this.anim.SetInteger("State", (int)state);
        Debug.Log(state);
        state = State.EnemyA;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       

        if (collision.tag == "PlayerBullet")
        {
            hp--;
            state = State.EnemyAHit;
        }

        this.anim.SetInteger("State", (int)state);

        Debug.LogFormat("EnemyA Hp : {0}", hp);
    }
}
