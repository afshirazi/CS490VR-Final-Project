using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCheck : MonoBehaviour
{
    public TextMesh ConfirmationTest;
    public GameObject Canvas;
    public string KanaTag;
    public bool Correct;

    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == KanaTag) {
            ConfirmationTest.text = "correct";
            Correct = true;
        } else {
            ConfirmationTest.text = "wrong";
            Correct = false;
        }
    }

    public void SetKanaTag(string NewKanaTag) {
        KanaTag = NewKanaTag;
    }

    public void ResetCanv() {
        ConfirmationTest.text = "";
        Correct = false;
    }
    
    void Start()
    {
        Correct = false;
        Canvas = GameObject.Find("Canvas");
        ConfirmationTest = Canvas.GetComponent<TextMesh>();
    }

    void Update()
    {

    }
}
