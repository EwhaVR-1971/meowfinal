using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dayCats : MonoBehaviour
{
    public float timer;
    public GameObject cat1;
    public GameObject cat2;
    public GameObject cat3;
    public GameObject cat4;
    public GameObject cat5;
    public GameObject cat6;
    public GameObject cat7;
    public GameObject cat8;
    public GameObject cat9;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;
    public GameObject Button6;
    public GameObject Button7;
    public GameObject Button8;
    public GameObject Button9;
    public GameObject but1;
    public GameObject but2;
    public GameObject but3;
    public GameObject but4;
    public GameObject but5;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < 3.3)
        {
            cat1.SetActive(true);
            Button1.SetActive(true);
        }
        else if (3.3 < timer && timer < 5.5)
        {
            cat1.SetActive(false);
            Button1.SetActive(false);
            cat2.SetActive(true);
            Button2.SetActive(true);
        }
        else if (5.5 < timer && timer < 7.8)
        {
            cat2.SetActive(false);
            Button2.SetActive(false);
            item1.SetActive(true);
            but1.SetActive(true);
        }
        else if (7.8 < timer && timer < 10.1)
        {
            item1.SetActive(false);
            but1.SetActive(false);
            cat3.SetActive(true);
            Button3.SetActive(true);
        }
        else if (10.1 < timer && timer < 15.4)
        {
            cat3.SetActive(false);
            Button3.SetActive(false);
            cat4.SetActive(true);
            Button4.SetActive(true);
        }
        else if (15.4 < timer && timer < 17.7)
        {
            cat4.SetActive(false);
            Button4.SetActive(false);
            item2.SetActive(true);
            but2.SetActive(true);
        }
        else if (17.7 < timer && timer < 20.0)
        {
            item2.SetActive(false);
            but2.SetActive(false);
            cat5.SetActive(true);
            Button5.SetActive(true);
        }
        else if (20.0 < timer && timer < 24.3)
        {
            cat5.SetActive(false);
            Button5.SetActive(false); ;
            cat6.SetActive(true);
            Button6.SetActive(true);
        }
        else if (24.3 < timer && timer < 29.3)
        {
            cat6.SetActive(false);
            Button6.SetActive(false);
            item3.SetActive(true);
            but3.SetActive(true);
        }
        else if (29.3 < timer && timer < 34.6)
        {
            item3.SetActive(false);
            but3.SetActive(false);
            cat7.SetActive(true);
            Button7.SetActive(true);
        }
        else if (34.6 < timer && timer < 36.9)
        {
            cat7.SetActive(false);
            Button7.SetActive(false);
            item4.SetActive(true);
            but4.SetActive(true);
        }
        else if (36.9 < timer && timer < 39.2)
        {
            item4.SetActive(false);
            but4.SetActive(false);
            cat8.SetActive(true);
            Button8.SetActive(true);
        }
        else if (39.2 < timer && timer < 42.5)
        {
            item5.SetActive(true);
            but5.SetActive(true);
            cat8.SetActive(false);
            Button8.SetActive(false);
            cat9.SetActive(true);
            Button9.SetActive(true);
        }
        else
        {
            item5.SetActive(false);
            but5.SetActive(false);
            cat9.SetActive(false);
            Button9.SetActive(false);
        }
   
    }
}
