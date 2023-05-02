using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    public int customerState;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (customerState == 1) {
            animator.SetTrigger("callOut");
            print("callout");
            customerState = 0;
        } 
        else if (customerState == 2) {
            animator.SetTrigger("thumbUp");
            print("thumbs up");
            customerState = 0;
        }
        else if (customerState == 3) {
            animator.SetTrigger("thumbDown");
            print("thumbs down");
            customerState = 0;
        }
    }

    public void SetCustomerState(int newCustomerState) {
        customerState = newCustomerState;
    }

}
