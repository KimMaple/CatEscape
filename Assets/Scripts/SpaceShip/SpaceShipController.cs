using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    private float limitPosition;    // X축 화면 제한 값 변수
    private float minX = -2.3f, maxX = 2.3f;    // 화면 제한 범위
    private float horizontal;   // X축
    private float vertical;     // Y축
    float speed = 10f;          // 플레이어 이동속도

    private int playerHp = 4;   // 플레이어 체력

    // Update is called once per frame
    void Update()
    {
        // 체력이 양수 일 때만 동작 가능
        if (playerHp > 0)
        {
            // 이동 메서드 호출
            Move();
        }else if(playerHp == 0)
        {
            Destroy(this.gameObject);
        }
        
    }

    private void Move()
    {
        // x 범위 밖으로 안나가도록 제한
        limitPosition = Mathf.Clamp(this.transform.position.x, minX, maxX);
        this.transform.position = new Vector3
            (limitPosition, transform.position.y, transform.position.z);

        // 키 입력
        horizontal = Input.GetAxisRaw("Horizontal"); // x (-1,0,1)
        vertical = Input.GetAxisRaw("Vertical");    // y (-1,0,1)

        // 플레이어 이동
        this.transform.Translate
            (new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerHp -= 1;
        Debug.Log(playerHp);
    }
}
