﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using UnityEngine.Events;

public class GVRButton : MonoBehaviour
{
    // public Image imgCircle;
    public GameObject cat1;
    //public GameObject cat3;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if(gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            // imgCircle.fillAmount = gvrTimer / totalTime;
        }

        if(gvrTimer>totalTime)
        {
            GVRClick.Invoke();
            // cat.SetActive(false);
        }
    }

    public void GvrOn()
    {
        gvrStatus = true;
    }

    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        // imgCircle.fillAmount = 0;
    }
    
    public void hit()
    {
        cat1.SetActive(false);
    }
}
