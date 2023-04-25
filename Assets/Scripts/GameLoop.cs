using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    public GameObject MyPressurePlate;
    public CharacterCheck PPScript;
    public AudioClip[] KanaSounds;
    public AudioSource CurrSound;
    private IEnumerator Coroutine;

    // Start is called before the first frame update
    void Start()
    {
        CurrSound = GetComponent<AudioSource>();
        PPScript = MyPressurePlate.GetComponent<CharacterCheck>();

        Coroutine = SetAndPlaySound();
        StartCoroutine(Coroutine);
    }

    IEnumerator SetAndPlaySound() {
        while (true){
            yield return new WaitForSeconds(3);
            int kana = (int)Random.Range(0, 4);
            PPScript.SetKanaTag("kana_a");
            CurrSound.clip = KanaSounds[kana];
            CurrSound.Play();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
