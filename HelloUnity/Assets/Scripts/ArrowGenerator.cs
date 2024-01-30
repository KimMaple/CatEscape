using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ArrowGenerator : MonoBehaviour
{
    //������ ������ ������ ������ �ν��Ͻ��� ����� 
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private CatEscapeGameDirector gameDirector;
    [SerializeField] private float span = 2;

    private float delta;    //����� �ð� ���� 


    void Update()
    {
        if (gameDirector.isGameOver) {
            ArrowController[] arrows = FindObjectsByType<ArrowController>(FindObjectsSortMode.None);
            foreach (ArrowController arrow in arrows) {
                Destroy(arrow.gameObject);
            }
            return;
        } 

        delta += Time.deltaTime;  //���� �����Ӱ� ���� ������ ���� �ð� 
        //Debug.Log(delta);
        if (delta > span)  //3�ʺ��� ũ�ٸ� 
        {
            //���� 
            GameObject go = UnityEngine.Object.Instantiate(this.arrowPrefab);
            //��ġ �� ���� 
            float randX = UnityEngine.Random.Range(-8, 9); //-8 ~ 8

            go.transform.position 
                = new Vector3(randX, go.transform.position.y, go.transform.position.z);

            delta = 0;  //��� �ð��� �ʱ�ȭ 
        }
    }
}
