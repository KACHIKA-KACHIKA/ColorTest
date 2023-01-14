using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public GameObject StartPanel, EndResult, Assets;
    [SerializeField] public Text TimerTextMin, TimerTextSec;
    public float TimerStartCount = 60 * 15;
    public int min = 0, sec = 0;
    public bool check = false;
    

    public void StartPanelButton()
    {
        StartPanel.SetActive(false);
        Assets.GetComponent<Main>().StartMain();
        Assets.SetActive(true);
        check = true;
    }
    void Start()
    {
        StartPanel.SetActive(true);
        Assets.SetActive(false);
    }

    public void Time_to_min()
    {
        if (TimerStartCount % 60 == 0)
        {
            min = (int)TimerStartCount / 60;
            sec = 0;
        }
        if (TimerStartCount == 0)
        {
            min = 0;
            sec = 0;
        }
        else
        {
            min = (int)TimerStartCount / 60;
            sec = (int)TimerStartCount % 60;
        }
    }
   
    public void Timer_countdown()
    { if (check)
        {
            TimerTextMin.text = min.ToString("00");
            TimerTextSec.text = sec.ToString("00");
            if (TimerStartCount >= 0)
            {
                Time_to_min();
                TimerStartCount -= Time.deltaTime * 1;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Timer_countdown();
    }
}
