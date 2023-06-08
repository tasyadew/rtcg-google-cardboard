using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonShow : ObjectController
{
    public float TotalTime = 2;
    public float timer;
    public UnityEvent action;
    public bool gazestatus;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gazestatus)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }

        if (timer > TotalTime)
        {
            action.Invoke();
        }
    }

    public void OnPointerEnter()
    {
        gazestatus = true;
    }

    public void OnPointerExit()
    {
        gazestatus = false;
        
    }

}
