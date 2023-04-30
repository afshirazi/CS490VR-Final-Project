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
    "kana_shi", "kana_se", "kana_so", "kana_ka", "kana_ku", "kana_ki", "kana_ke", "kana_ko" };
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
        while (true){
            yield return new WaitForSeconds(5);
            PPScript.ResetCanv();
            FCScript.ResetFoods();
            asc.SetCustomerState(0); // idle
            yield return new WaitForSeconds(5);
            int kana = Random.Range(0, 20);
            FCScript.SetChosenLabel(kana);
            PPScript.SetKanaTag(TagList[kana]);
            CurrSound.clip = KanaSounds[kana];
            CurrSound.Play();
            asc.SetCustomerState(1); // call out sound
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
