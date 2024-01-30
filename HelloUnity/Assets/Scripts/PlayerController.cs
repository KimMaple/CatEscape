using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CatEscapeGameDirector gameDirector;

    public float radius = 1f;

    public int maxHp = 13;
    public int hp;

    private void Awake()
    {
        this.hp = this.maxHp;
        Debug.LogFormat("<color=yellow>{0}/{1}</color>", this.hp, this.maxHp);
    }

    void Update()
    {
        if (gameDirector.isGameOver) return;

        //Ű���� �Է��� �޴� �ڵ� �ۼ� 
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("�������� 2���ָ�ŭ �̵�");
            //X ������-2��ŭ �̵� 
            this.transform.Translate(-2, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("���������� 2���ָ�ŭ �̵�");
            //X������ 2��ŭ �̵� 
            this.transform.Translate(2, 0, 0);
        }

        float clampX = Mathf.Clamp(this.transform.position.x, -8.13f, 8.13f);
        Vector3 pos = this.transform.position;
        pos.x = clampX;
        this.transform.position = pos;
    }

    //�̺�Ʈ �Լ� 
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
