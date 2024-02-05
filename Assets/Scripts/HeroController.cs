using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public int MaxHp {  get; set; }
    public int Hp { get; set; }

    public System.Action onHit;

    private void Start()
    {
        MaxHp = 10;
        this.Hp = this.MaxHp;
        Debug.LogFormat("{0}/{1}", this.Hp, this.MaxHp);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Hp -= 1;
            if (this.Hp <= 0) this.Hp = 0;
            //Debug.LogFormat("{0}/{1}", this.Hp, this.MaxHp);
            this.onHit();
        }
    }

}
