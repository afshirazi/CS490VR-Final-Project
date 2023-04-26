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
            animator.SetBool("isCallOut", true);
        } else {
            animator.SetBool("isCallOut", false);
        }
        
    }

    public void SetCustomerState(int newCustomerState) {
        customerState = newCustomerState;
    }
}
