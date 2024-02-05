using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisakiController : MonoBehaviour
{
    Coroutine coroutine;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawLine(ray.origin, ray.direction*20,Color.red,5);

            RaycastHit hit;
            if(Physics.Raycast(ray.origin,ray.direction,out hit,20))
            {
                Vector3 tpos = new Vector3(0, 0, 0);
                tpos.x = hit.point.x;
                tpos.y = 0;
                tpos.z = hit.point.z;

                Debug.Log(tpos);

                //코루틴
                if (this.coroutine != null)
                    StopCoroutine(this.coroutine);

                this.coroutine = StartCoroutine(this.CoMove(tpos));
            }
        }
    }

    IEnumerator CoMove(Vector3 tpos)
    {
        this.transform.LookAt(tpos); // 바라본다.

        while (true)
        {
            this.transform.Translate(Vector3.forward * 1f * Time.deltaTime);
            float distance = (tpos - this.transform.position).magnitude;
            Debug.LogFormat("distance : {0}", distance);
            if((int)distance == 0)
            {
                break;
            }
            yield return null;
        }
        
        Debug.Log("이동속도");
    }
}
