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
    float speed = 0.01f;
    Vector3 target = new Vector3(-0.12f, 0.28f, -12.42f);

    void Start()
    {
        instance = this.gameObject;
        originScale = instance.transform.localScale; 
    }

    void Update()
    {
        instance.transform.position = Vector3.MoveTowards(instance.transform.position, target, 0.03f);
        if (instance.transform.position == target){
            Destroy(instance);
        }
        if (gvrStatus)
        {
            instance.transform.localScale = originScale*(1+gvrTimer*speed);
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

 
            
            

            