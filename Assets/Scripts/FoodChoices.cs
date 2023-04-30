using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodChoices : MonoBehaviour
{
    public Material[] Chars;
    public GameObject[] Foodlabels;
    public Renderer[] FoodlabelRend;
    private string[] TagList = {"kana_a", "kana_u", "kana_i", "kana_e", "kana_o", "kana_ta", "kana_tsu", "kana_chi", "kana_te", "kana_to", "kana_sa", "kana_su", 
    "kana_shi", "kana_se", "kana_so", "kana_ka", "kana_ku", "kana_ki", "kana_ke", "kana_ko" };
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
        Foodlabels[idx].transform.parent.gameObject.tag = TagList[Chara];

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
                        Foodlabels[i].transform.parent.gameObject.tag = TagList[otherChar1];
                        j++;
                        break;
                    case 1:
                        FoodlabelRend[i].material = Chars[otherChar2];
                        Foodlabels[i].transform.parent.gameObject.tag = TagList[otherChar2];
                        j++;
                        break;
                    case 2:
                        FoodlabelRend[i].material = Chars[otherChar3];
                        Foodlabels[i].transform.parent.gameObject.tag = TagList[otherChar3];
                        break;
                }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
