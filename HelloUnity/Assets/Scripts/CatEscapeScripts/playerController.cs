using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;


public class playerController : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image hpGauag;

    public float radius = 0.8f;

    public float minf = -8f, maxf = 8f;

    void Update()
    {
        // 체력이 0이 아닐떄만 동작 가능
        if(hpGauag.fillAmount > 0)
        {
            if (this.transform.position.x <= minf)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    this.transform.Translate(5 * Time.deltaTime, 0, 0);
                }
            }
            if (this.transform.position.x >= maxf)
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    this.transform.Translate(-5 * Time.deltaTime, 0, 0);
                }
            }

            if (this.transform.position ==
                new Vector3(Mathf.Clamp(this.transform.position.x, minf, maxf),
                this.transform.position.y, this.transform.position.z))
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    this.transform.Translate(-5 * Time.deltaTime, 0, 0);
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    this.transform.Translate(5 * Time.deltaTime, 0, 0);
                }
            }
        }
               
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
