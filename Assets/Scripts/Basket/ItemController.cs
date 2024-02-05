using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    /*public enum itemType
    {

    }*/


    void Update()
    {
        this.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        // y축의 값이 0이하면 제거
        if(this.transform.position.y <= 0)
        {

            Destroy(this.gameObject);
        }
    }
}
