using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneMain : MonoBehaviour
{
    [SerializeField] private Text textHp;
    [SerializeField] private Button btnLoadScene;
    [SerializeField] private GameObject heroPrefab;
    [SerializeField] private HeroDataManager heroDataManager;
    // Update is called once per frame
    void Start()
    {
        
        this.btnLoadScene.onClick.AddListener(() =>
        {
            Debug.Log("VillegeScene으로 전환");
            SceneManager.LoadScene("VillegeScene");
        });
        this.CreateHero();
    }

    private void CreateHero()
    {
        GameObject heroGo = Instantiate(heroPrefab);
        Debug.LogFormat("heroGo: {0}", heroGo);
        HeroController heroController = heroGo.GetComponent<HeroController>();

        heroController.onHit = () => {      // 대리자를 이용한 호출

            Debug.Log("영웅이 패해를 받았습니다.");
            Debug.LogFormat("{0}/{1}",heroController.Hp, heroController.MaxHp);

            this.heroDataManager.UpdateHeroHpAndMaxHp(heroController.Hp, heroController.MaxHp);

            this.textHp.text = string.Format("{0}/{1}", heroController.Hp, heroController.MaxHp);
        };
    }
}
