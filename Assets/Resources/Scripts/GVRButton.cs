using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using UnityEngine.Events;

public class GVRButton : MonoBehaviour
{
    // public Image imgCircle;
    public GameObject obj;
    //public GameObject cat3;
    public UnityEvent GVRClick;
    public float totalTime;
    bool gvrStatus;
    public float gvrTimer;
    // public float totalScore = 0;
    // bool isDone = false;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if(gvrStatus)
        {
            gvrTimer = gvrTimer + Time.deltaTime;
            // imgCircle.fillAmount = gvrTimer / totalTime;
        }

        if(gvrTimer + 0.7>totalTime)
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
        // obj.SetActive(false);
        // totalScore += 1;
        Debug.Log("hit");
    }
}
