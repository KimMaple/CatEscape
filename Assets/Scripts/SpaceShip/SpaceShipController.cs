using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    private float limitPosition;    // X�� ȭ�� ���� �� ����
    private float minX = -2.3f, maxX = 2.3f;    // ȭ�� ���� ����
    private float horizontal;   // X��
    private float vertical;     // Y��
    float speed = 10f;          // �÷��̾� �̵��ӵ�

    private int playerHp = 4;   // �÷��̾� ü��

    // Update is called once per frame
    void Update()
    {
        // ü���� ��� �� ���� ���� ����
        if (playerHp > 0)
        {
            // �̵� �޼��� ȣ��
            Move();
        }else if(playerHp == 0)
        {
            Destroy(this.gameObject);
        }
        
    }

    private void Move()
    {
        // x ���� ������ �ȳ������� ����
        limitPosition = Mathf.Clamp(this.transform.position.x, minX, maxX);
        this.transform.position = new Vector3
            (limitPosition, transform.position.y, transform.position.z);

        // Ű �Է�
        horizontal = Input.GetAxisRaw("Horizontal"); // x (-1,0,1)
        vertical = Input.GetAxisRaw("Vertical");    // y (-1,0,1)

        // �÷��̾� �̵�
        this.transform.Translate
            (new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerHp -= 1;
        Debug.Log(playerHp);
    }
}
