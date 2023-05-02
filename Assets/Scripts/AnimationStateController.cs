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
            animator.SetInteger("CustomerReaction", 1); // call out
            print("call out");
        } 
        else if (customerState == 2) {
            animator.SetInteger("CustomerReaction", 2); // thumbs up
            print("thumbs up");
        }
        else if (customerState == 3) {
            animator.SetInteger("CustomerReaction", 3); // thumbs down
            print("thumbs down");
        }
        else {
            animator.SetInteger("CustomerReaction", 0);
        }
    }

    public void SetCustomerState(int newCustomerState) {
        customerState = newCustomerState;
    }

}
