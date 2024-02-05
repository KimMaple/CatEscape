using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test2Making : MonoBehaviour
{
    [SerializeField] private Transform cubeTransform;


    void Update()
    {
        // 화면을 클릭하면 레이를 발사
        if (Input.GetMouseButtonDown(0))
        {
            // 픽셀 좌표를 가지고 월드 안에서 레이 객체를 만든다.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // 레이 객체가 가지고 있는 속성
            // ray.origin : 시작 위치
            // ray.direction : 방향

            // 눈으로 레이보기
            //              시작점       방향 * 거리 증가    색상      출현 시간
            Debug.DrawRay(ray.origin, ray.direction * 15, Color.red, 10);

            // 레이와 콜라이더 충돌 체크
            RaycastHit hit; // 충돌했다면 충돌 정보를 담는 변수

            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20f))
            {
                // 레이와 콜라이더가 충돌함
                Debug.Log("충돌함");
                Debug.LogFormat("충돌위치 : {0}", hit.point);   // 충돌 지점 위치
                cubeTransform.position = hit.point;

                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);

                cubeTransform.position = new Vector3(x, cubeTransform.position.y, z);
            }         
        }
    }
}
