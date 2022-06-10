using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GVRButton : MonoBehaviour
{
    // public Image imgCircle;
    public GameObject obj;
    private GameManager manager;
    public GameObject cat1;
    public GameObject water;
    public GameObject paw;
    public GameObject food;
    public GameObject rotten;
    public GameObject choco;
    public UnityEvent GVRClick;
    public float totalTime;
    bool gvrStatus;
    public float gvrTimer;
    // public int totalScore;  // 점수 합산
    public int isDone = 0;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
            isDone += 1;
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

    public void GoToStart()
    {

        SceneManager.LoadScene("End");
    }

    public void hit()
    {
        if (isDone == 1)
        {
            manager.totalScore += 1;
            Debug.Log(manager.totalScore);
        }
    }
}
