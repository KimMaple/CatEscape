using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] GameObject enemyAPrefab;
    [SerializeField] GameObject camera;

    void Start()
    {
        
        StartCoroutine(CoAGenerator());
    }

    private IEnumerator CoAGenerator()
    {
        if((int)camera.transform.position.y % 3 == 0)
        {
            for(int x = -2; x < 5; x++)
            {
                this.enemyAPrefab.transform.position = new Vector3
                    (x,camera.transform.position.y + 8,camera.transform.position.z);
                yield return Instantiate(enemyAPrefab);
            }          
        }
    } 
}
