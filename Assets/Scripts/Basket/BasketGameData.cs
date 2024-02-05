using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketGameData : MonoBehaviour
{
    public int BasketPoint { get; set; }
    public int ApplePoint {  get; set; }
    public int BombPoint {  get; set; }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void UploadScoreData(int point, int apple, int bomb)
    {
        this.BasketPoint = point;
        this.ApplePoint = apple;
        this.BombPoint = bomb;
        Debug.LogFormat("point : {0}", this.BasketPoint);
        Debug.LogFormat("Apple : {0}", this.ApplePoint);
        Debug.LogFormat("Bomb! : {0}", this.BombPoint);
    }
}
