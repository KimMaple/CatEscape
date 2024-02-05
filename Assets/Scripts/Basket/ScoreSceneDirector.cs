using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreSceneDirector : MonoBehaviour
{
    [SerializeField] private Text pointText;
    [SerializeField] private Button btnRestart;
    private int point;
    private int apple;
    private int bomb;

    private void Start()
    {
        point = GameObject.Find("GameData").GetComponent<BasketGameData>().BasketPoint;
        apple = GameObject.Find("GameData").GetComponent<BasketGameData>().ApplePoint;
        bomb = GameObject.Find("GameData").GetComponent<BasketGameData>().BombPoint;
        pointText.text = $"{point} ��\n" +
            $"��� : {apple} ��\n" +
            $"��ź : {bomb} ��";

        this.btnRestart.onClick.AddListener(() => {
            Debug.Log("�Էµ�");
            SceneManager.LoadScene("Basket");
        });
    }
}
