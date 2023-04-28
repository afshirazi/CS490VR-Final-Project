using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodChoices : MonoBehaviour
{
    public Material[] Chars;
    public GameObject[] Foodlabels;
    public Renderer[] FoodlabelRend;
    // Start is called before the first frame update
    void Start()
    {
        FoodlabelRend[0] = Foodlabels[0].GetComponent<Renderer>();
        FoodlabelRend[1] = Foodlabels[1].GetComponent<Renderer>();
        FoodlabelRend[2] = Foodlabels[2].GetComponent<Renderer>();
        FoodlabelRend[3] = Foodlabels[3].GetComponent<Renderer>();
    }

    public void SetChosenLabel(int Chara) {
        int idx = Random.Range(0, 4);
        FoodlabelRend[idx].material = Chars[Chara];

        int otherChar1 = Random.Range(0, 20); 
        while (otherChar1 == Chara) {
            otherChar1 = Random.Range(0, 20); 
        }

        int otherChar2 = Random.Range(0, 20); 
        while (otherChar2 == otherChar1 || otherChar2 == Chara) {
            otherChar2 = Random.Range(0, 20); 
        }

        int otherChar3 = Random.Range(0, 20);  
        while (otherChar3 == otherChar1 || otherChar3 == otherChar2 || otherChar3 == Chara) {
            otherChar3 = Random.Range(0, 20); 
        }

        int j = 0;
        for (int i = 0; i < 4; i++) {
            if (i != idx) 
                switch (j) {
                    case 0:
                        FoodlabelRend[i].material = Chars[otherChar1];
                        j++;
                        break;
                    case 1:
                        FoodlabelRend[i].material = Chars[otherChar2];
                        j++;
                        break;
                    case 2:
                        FoodlabelRend[i].material = Chars[otherChar3];
                        break;
                }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
