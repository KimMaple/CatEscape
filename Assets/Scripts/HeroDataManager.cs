using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDataManager : MonoBehaviour
{
    private int heroHp = 0;
    private int heroMaxHp = 0;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateHeroHpAndMaxHp(int heroHp, int heroMaxHp)
    {
        this.heroHp = heroHp;
        this.heroMaxHp = heroMaxHp;

        Debug.LogFormat("»õ ¾À{0}/{1}", heroHp, heroMaxHp);
    }
}
