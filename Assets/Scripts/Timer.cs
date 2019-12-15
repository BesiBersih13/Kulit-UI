using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [Tooltip("Berapa Lama delay")]
    public float delay;

    private float timer;

    public UnityEvent onDuar;
    
    private bool timerActive;

    public void StartTimer()
    {
        timerActive = true;
        timer = delay;
    }
    

    private void FixedUpdate()
    {
        if (timerActive)
        {
            
            timer = timer - Time.deltaTime;
            if (timer <=0)
            {
                onDuar.Invoke();
                print("duuarr");
                timerActive = false;
            }
        }
    }
}
