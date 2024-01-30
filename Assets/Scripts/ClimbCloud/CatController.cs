using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float force = 300f;
    private Vector3 left = new Vector3(-1, 0, 0);
    private Vector3 right = new Vector3(1, 0, 0);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.LeftArrow))
        {
            this.rbody.AddForce(this.left + this.transform.up * this.force);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.RightArrow))
        {
            this.rbody.AddForce(this.right + this.transform.up * this.force);
        }
        // 스페이스바 클릭
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            // 점프(힘을 가한다.)
            this.rbody.AddForce(this.transform.up * this.force);    // 로컬 기준
            //this.rbody.AddForce(Vector3.up * this.force); // 월드 기준     
        }
        
    }
}
