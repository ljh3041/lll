using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class Timer : MonoBehaviour
{
    public TMP_Text timerText;

    public float timer;

    private Coroutine timerCoroutine; // 코루틴 참조

    public void Start()
    {
        timerCoroutine = StartCoroutine(OnTimer_Cor()); // 코루틴 시작
    }
    IEnumerator OnTimer_Cor()
    {
        while (true)
        {
            timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(timer / 60);
            int seconds = Mathf.FloorToInt(timer % 60);
            float milliseconds = (timer * 100) % 100; // 소수점
            timerText.text = string.Format("{0:D2}:{1:D2}:{2:00}", minutes, seconds, Mathf.FloorToInt(milliseconds));
            yield return null;
        }
    }

    public void StopTimer_Cor()
    {
        if (timerCoroutine != null)
        {
            StopCoroutine(timerCoroutine); // 코루틴 멈추기
            timerCoroutine = null; // 참조 초기화
        }
    }

    private void Update()
    {
        
    }


}
