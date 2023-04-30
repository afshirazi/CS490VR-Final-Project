using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCheck : MonoBehaviour
{
    public TextMesh ConfirmationTest;
    public GameObject Canvas;
    public string KanaTag;

    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == KanaTag) {
            ConfirmationTest.text = "correct";
        } else {
            ConfirmationTest.text = "wrong";
        }
    }

    public void SetKanaTag(string NewKanaTag) {
        KanaTag = NewKanaTag;
    }

    public void ResetCanv() {
        ConfirmationTest.text = "";
    }
    
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        ConfirmationTest = Canvas.GetComponent<TextMesh>();
    }

    void Update()
    {

    }
}
