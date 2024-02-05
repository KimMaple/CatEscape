using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] GameObject applePrefab;
    [SerializeField] GameObject bombPrefab;
    private float delta;
    void Start()
    {

    }


    private void Update()
    {


        int appleX = Random.Range(-1, 2);
        int appleZ = Random.Range(-1, 2);
        int bombX = Random.Range(-1, 2);
        int bombZ = Random.Range(-1, 2);

        delta += Time.deltaTime; // 이전 프레임과 현재 프레임 사이 시간
                                 //Debug.LogFormat("delta = {0}", delta);

        if (delta > 3)
        {
            this.applePrefab.transform.position = new Vector3
            (appleX, applePrefab.transform.position.y, appleZ);
            this.bombPrefab.transform.position = new Vector3
                (bombX, bombPrefab.transform.position.y, bombZ);
            Instantiate(this.applePrefab);
            Instantiate(this.bombPrefab);
            delta = 0;
        }
    }
}
