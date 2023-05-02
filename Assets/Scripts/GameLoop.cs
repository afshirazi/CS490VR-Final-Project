using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    public GameObject MyPressurePlate;
    public CharacterCheck PPScript;
    public GameObject MyFoodChoices;
    public FoodChoices FCScript;
    public AnimationStateController asc;
    public AudioClip[] KanaSounds;
    public AudioSource CurrSound;
    private IEnumerator Coroutine;
    private string[] TagList = {"kana_a", "kana_u", "kana_i", "kana_e", "kana_o", "kana_ta", "kana_tsu", "kana_chi", "kana_te", "kana_to", "kana_sa", "kana_su", 
    "kana_shi", "kana_se", "kana_so", "kana_ka", "kana_ku", "kana_ki", "kana_ke", "kana_ko", "kana_na", "kana_nu", "kana_ni", "kana_ne", "kana_no", "kana_ma", "kana_mu", "kana_mi", "kana_me", "kana_mo", 
    "kana_ra", "kana_ru", "kana_ri", "kana_re", "kana_ro", "kana_ha", "kana_fu", "kana_hi", "kana_he", "kana_ho"};

    // Start is called before the first frame update
    void Start()
    {
        CurrSound = GetComponent<AudioSource>();
        PPScript = MyPressurePlate.GetComponent<CharacterCheck>();
        FCScript = MyFoodChoices.GetComponent<FoodChoices>();

        Coroutine = SetAndPlaySound();
        StartCoroutine(Coroutine);
    }

    IEnumerator SetAndPlaySound() {
        while (true) {
            PPScript.ResetCanv();
            FCScript.ResetFoods();
            int kana = Random.Range(0, 40);
            FCScript.SetChosenLabel(kana);
            PPScript.SetKanaTag(TagList[kana]);
            CurrSound.clip = KanaSounds[kana];
            yield return new WaitForSeconds(1.5f);
            asc.SetCustomerState(1); // call out sound
            CurrSound.Play();
            yield return new WaitForSeconds(12f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}