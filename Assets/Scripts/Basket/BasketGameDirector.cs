using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketGameDirector : MonoBehaviour
{
    private Text pointText;
    private int point;
    [SerializeField] private GameObject basket;
    [SerializeField] private GameObject pointGo;
    [SerializeField] private GameObject timeGo;

    public int Persent {  get; set; }

    private Text timeText;
    int foolSec;
    float sec;
    private void Start()
    {
        this.Persent = 50;
        this.foolSec = 30;
        this.timeText = timeGo.GetComponent<Text>();
        this.pointText = pointGo.GetComponent<Text>();
    }

    void Update()
    {
        this.point = basket.GetComponent<BasketController>().Point;
        sec += Time.deltaTime;
        if(sec > 1 )
        {
            this.foolSec = foolSec - (int)sec;
            this.pointText.text = $"점수 : {point}";
            this.timeText.text = $"남은 시간 : {foolSec}";
            sec = 0;
        }
        if(foolSec == 0)
        {
            SceneManager.LoadScene("ScoreScene");
        }
    }
}
