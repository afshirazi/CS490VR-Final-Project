using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTimer : MonoBehaviour
{
    
    public float TimerValue;
    public bool Running;

    // Start is called before the first frame update
    void Start()
    {
        TimerValue = 0f;
        Running = false;
    }

    public void StartTimer() {
        Running = true;
    }

    public void ResetTimer() {
        Running = false;
        TimerValue = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Running) {
            TimerValue += Time.deltaTime;
        } 
    }
}
