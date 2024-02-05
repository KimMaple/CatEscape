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
        // ȭ���� ��ġ�ϸ� ��ġ�� ��ġ�� �ٽ�Ŷ�� �����δ�.

        // 1. ȭ���� ��ġ(Ŭ��)�ϸ� 
        if (Input.GetMouseButtonDown(0))
        {
            // Ray�� �����.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // �������� RaycastHit hit ����
            RaycastHit hit;

            // if�� �ۼ� Physics.Raycast�� Ray�� �ݶ��̴��� �浹���� �� true���� ��ȯ
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20f))
            {
                // ���̿� �ݶ��̴��� �浹�ߴٸ� 
                // �ٱ����� ��ġ�� �����δ�.
                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);
                this.transform.position = new Vector3(x, this.transform.position.y, z);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple")) // �Ʒ� ���ϰ� ������ ���ǽ�
        {
            Debug.Log("����");
            this.point+=10;
            this.audioSource.PlayOneShot(this.appleSfx);
        }
        else if (other.tag == "Bomb") 
        {
            Debug.Log("����");
            this.point-=10;
            this.audioSource.PlayOneShot(this.bombSfx);
        }
        Debug.LogFormat("point : {0}", this.point);
        Destroy(other.gameObject);
    }
}
