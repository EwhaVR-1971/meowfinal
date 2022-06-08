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

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < 3.2)
        {
            cat1.SetActive(true);
        }
        else if (3.2 < timer && timer < 5.2)
        {
            cat1.SetActive(false);
            cat2.SetActive(true);
        }
        else if (5.2 < timer && timer < 7.2)
        {
            cat2.SetActive(false);
            item1.SetActive(true);
        }
        else if (7.2 < timer && timer < 9.2)
        {
            item1.SetActive(false);
            cat3.SetActive(true);
        }
        else if (9.2 < timer && timer < 14.2)
        {
            cat3.SetActive(false);
            cat4.SetActive(true);
        }
        else if (14.2 < timer && timer < 16.2)
        {
            cat4.SetActive(false);
            item2.SetActive(true);
        }
        else if (16.2 < timer && timer < 18.2)
        {
            item2.SetActive(false);
            cat5.SetActive(true);
        }
        else if (18.2 < timer && timer < 22.2)
        {
            cat5.SetActive(false);
            cat6.SetActive(true);
        }
        else if (22.2 < timer && timer < 27.2)
        {
            cat6.SetActive(false);
            item3.SetActive(true);
        }
        else if (22.2 < timer && timer < 27.2)
        {
            item3.SetActive(false);
            cat7.SetActive(true);
        }
        else if (27.2 < timer && timer < 29.2)
        {
            cat7.SetActive(false);
            item4.SetActive(true);
        }
        else if (29.2 < timer && timer < 31.2)
        {
            item4.SetActive(false);
            cat8.SetActive(true);
        }
        else if (31.2 < timer && timer < 34.2)
        {
            item5.SetActive(true);
            cat8.SetActive(false);
            cat9.SetActive(true);
        }
    }
}
