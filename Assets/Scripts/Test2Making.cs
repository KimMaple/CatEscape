using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test2Making : MonoBehaviour
{
    [SerializeField] private Transform cubeTransform;


    void Update()
    {
        // ȭ���� Ŭ���ϸ� ���̸� �߻�
        if (Input.GetMouseButtonDown(0))
        {
            // �ȼ� ��ǥ�� ������ ���� �ȿ��� ���� ��ü�� �����.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // ���� ��ü�� ������ �ִ� �Ӽ�
            // ray.origin : ���� ��ġ
            // ray.direction : ����

            // ������ ���̺���
            //              ������       ���� * �Ÿ� ����    ����      ���� �ð�
            Debug.DrawRay(ray.origin, ray.direction * 15, Color.red, 10);

            // ���̿� �ݶ��̴� �浹 üũ
            RaycastHit hit; // �浹�ߴٸ� �浹 ������ ��� ����

            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20f))
            {
                // ���̿� �ݶ��̴��� �浹��
                Debug.Log("�浹��");
                Debug.LogFormat("�浹��ġ : {0}", hit.point);   // �浹 ���� ��ġ
                cubeTransform.position = hit.point;

                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);

                cubeTransform.position = new Vector3(x, cubeTransform.position.y, z);
            }         
        }
    }
}
