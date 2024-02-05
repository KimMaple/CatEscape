using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    [SerializeField] private AudioClip appleSfx;
    [SerializeField] private AudioClip bombSfx;

    private AudioSource audioSource;

    int point;

    public int GetPoint()
    {
        return this.point;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // 화면을 터치하면 터치한 위치로 바스킷을 움직인다.

        // 1. 화면을 터치(클릭)하면 
        if (Input.GetMouseButtonDown(0))
        {
            // Ray를 만든다.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // 지역변수 RaycastHit hit 정의
            RaycastHit hit;

            // if문 작성 Physics.Raycast는 Ray랑 콜라이더가 충돌했을 때 true값을 반환
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20f))
            {
                // 레이와 콜라이더가 충돌했다면 
                // 바구니의 위치를 움직인다.
                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);
                this.transform.position = new Vector3(x, this.transform.position.y, z);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple")) // 아래 붐하고 동일한 조건식
        {
            Debug.Log("득점");
            this.point+=10;
            this.audioSource.PlayOneShot(this.appleSfx);
        }
        else if (other.tag == "Bomb") 
        {
            Debug.Log("감점");
            this.point-=10;
            this.audioSource.PlayOneShot(this.bombSfx);
        }
        Debug.LogFormat("point : {0}", this.point);
        Destroy(other.gameObject);
    }
}
