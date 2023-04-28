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
            yield return new WaitForSeconds(3);
            asc.SetCustomerState(0); // idle
            yield return new WaitForSeconds(2);
            int kana = Random.Range(0, 5);
            FCScript.SetChosenLabel(kana);
            PPScript.SetKanaTag("kana_a");
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
