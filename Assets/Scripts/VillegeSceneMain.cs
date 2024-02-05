using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VillegeSceneMain : MonoBehaviour
{
    [SerializeField] private Text textHp;
    [SerializeField] private GameObject heroPrefab;
    private HeroDataManager heroDataManager;
    // Update is called once per frame
    void Start()
    {
        heroDataManager = new HeroDataManager();
        this.CreateHero();
    }

    private void CreateHero()
    {
        GameObject heroGo = Instantiate(heroPrefab);
        Debug.LogFormat("heroGo: {0}", heroGo);
        HeroController heroController = heroGo.GetComponent<HeroController>();

        heroController.onHit = () => {      // �븮�ڸ� �̿��� ȣ��

            Debug.Log("������ ���ظ� �޾ҽ��ϴ�.");
            Debug.LogFormat("{0}/{1}", heroController.Hp, heroController.MaxHp);

            this.heroDataManager.UpdateHeroHpAndMaxHp(heroController.Hp, heroController.MaxHp);

            this.textHp.text = string.Format("{0}/{1}", heroController.Hp, heroController.MaxHp);
        };
    }
}
