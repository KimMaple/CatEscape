using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketGameDirector : MonoBehaviour
{
    private Text pointText;
    private int point;
    [SerializeField] private GameObject pointGo;
    [SerializeField] private GameObject timeGo;
    private Text timeText;
    float sec;

    private string pointT;

    private void Start()
    {
        timeText = timeGo.GetComponent<Text>();
        pointText = pointGo.GetComponent<Text>();
    }

    void Update()
    {
        pointT += string.Format("Á¡¼ö : {0}",point);
        BasketController basketController = new BasketController();
        this.point = basketController.GetPoint();
        sec += Time.deltaTime;

        this.pointText.text = pointT;
        //timeText.text = $"{sec:D2}";
        
    }
}
