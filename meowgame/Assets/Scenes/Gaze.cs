using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject instance;
    //public Image imgGaze;
    public Vector3 originScale;
    public float totalTime;
    float gvrTimer;
    bool gvrStatus;

    void Start()
    {
        instance = this.gameObject;
        originScale = instance.transform.localScale; 
    }

    void Update()
    {
        if (gvrStatus)
        {
            instance.transform.localScale = originScale * (1+gvrTimer);
            gvrTimer += Time.deltaTime;
            if(gvrTimer > totalTime){

                Destroy(instance);
            }
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        instance.transform.localScale = originScale;
    }
}

 
            
            

            