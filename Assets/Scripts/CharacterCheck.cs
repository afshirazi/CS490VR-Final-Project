using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCheck : MonoBehaviour
{
    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "kana_i") {
           print("correct");
        } else if (other.gameObject.tag == "kana_a") {
            print("wrong");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
