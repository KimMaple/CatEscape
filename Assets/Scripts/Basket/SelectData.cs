using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectData : MonoBehaviour
{
    [SerializeField] SelectGameDirector gameDirector;
    public int MinusPoint { get; set; }
    public int ApplePersent { get; set; }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateSelectData(int mPoint, int aPersent)
    {
        this.MinusPoint= mPoint;
        this.ApplePersent= aPersent;

        Debug.LogFormat("minusPoint : {0}", this.MinusPoint);
        Debug.LogFormat("ApplePersent : {0}", this.ApplePersent);

    }
}
