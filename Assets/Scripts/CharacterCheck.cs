using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCheck : MonoBehaviour
{
    public TextMesh ConfirmationTest;
    public GameObject Canvas;
    public string KanaTag;
    public AnimationStateController asc;
    public AudioSource CurrSound;
    public AudioClip CorrectSound;
    public AudioClip IncorrectSound;

    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == KanaTag) {
            ConfirmationTest.text = "Correct";
            ConfirmationTest.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            asc.SetCustomerState(2); // thumbs up
            CurrSound.clip = CorrectSound;
            CurrSound.Play();
        } else {
            ConfirmationTest.text = "Wrong";
            ConfirmationTest.color = new Color(0.0f, 0.0f, 1.0f, 1.0f);
            asc.SetCustomerState(3); // thumbs down
            CurrSound.clip = IncorrectSound;
            CurrSound.Play();
        }
    }

    public void SetKanaTag(string NewKanaTag) {
        KanaTag = NewKanaTag;
    }

    public void ResetCanv() {
        ConfirmationTest.text = "";
        ConfirmationTest.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }
    
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        ConfirmationTest = Canvas.GetComponent<TextMesh>();
        CurrSound = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
}
