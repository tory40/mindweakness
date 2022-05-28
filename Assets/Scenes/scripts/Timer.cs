using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timerText;
    private float second;
    private int minute;
    private int hour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.first2&&Deck.ta)
        {
            second += Time.deltaTime;
            if (second > 60f)
            {
                ++minute;
                second -= 60f;
            }
            if (minute > 60)
            {
                ++hour;
                minute -= 60;
            }
            timerText.text = hour.ToString() + ":" + minute.ToString("00") + ":" + second.ToString("00.00");
        }
    }
}
