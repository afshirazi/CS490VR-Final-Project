using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterCheck : MonoBehaviour
{
    public TMP_Text ConfirmationTest;
    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "kana_i") {
            ConfirmationTest.text = "correct";
        } else {
            ConfirmationTest.text = "wrong";
        }
    }
    void Start()
    {
        ConfirmationTest = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
    }
}
