using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] BasketGameDirector gameDirector;
    [SerializeField] GameObject applePrefab;
    [SerializeField] GameObject bombPrefab;
    private float delta;
    Coroutine coroutine;
    int persent;
    private SelectData selectData;

    private void Start()
    {
        selectData = GameObject.Find("SelectData").GetComponent<SelectData>();
        this.persent = selectData.ApplePersent;
    }

    private void Update()
    {
        persent = gameDirector.Persent;

        if(coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        coroutine = StartCoroutine(this.CoGenerate());
    }

    private IEnumerator CoGenerate()
    {
        int who = Random.Range(0,100);   // 0이면 폭탄 1이면 사과
        int x = Random.Range(-1, 2);
        int z = Random.Range(-1, 2);

        delta += Time.deltaTime; // 이전 프레임과 현재 프레임 사이 시간
                                 //Debug.LogFormat("delta = {0}", delta);

        if (delta > 1.4)
        {
            this.applePrefab.transform.position = new Vector3
            (x, applePrefab.transform.position.y, z);
            this.bombPrefab.transform.position = new Vector3
                (x, bombPrefab.transform.position.y, z);
            if (who >= this.persent)
            {
                Instantiate(this.applePrefab);
            }
            else if (who < this.persent)
            {
                Instantiate(this.bombPrefab);
            }

            delta = 0;
        }
        yield return null;
    }
}
