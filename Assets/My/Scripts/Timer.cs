using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    public TMP_Text timerText;

    public float timer;

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        timerText.text = ((int)timer / 60 % 60).ToString("D2") + ":" + ((int)timer % 60).ToString("D2") + ":" + (Mathf.Floor(timer * 100f) % 100f).ToString();
    }//



    /*public int timer = 0;

    private void Start()
    {
        StartCoroutine(TimerCoroution());
    }

    IEnumerator TimerCoroution()
    {
        timer += 1;

        timerText.text =  (timer / 60 % 60).ToString("D2") + ":" + (timer % 60).ToString("D2");

        yield return new WaitForSeconds(1f);

        StartCoroutine(TimerCoroution());
    }
    */
}
