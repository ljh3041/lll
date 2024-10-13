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

    private Coroutine timerCoroutine; // �ڷ�ƾ ����

    public void Start()
    {
        timerCoroutine = StartCoroutine(OnTimer_Cor()); // �ڷ�ƾ ����
    }
    IEnumerator OnTimer_Cor()
    {
        while (true)
        {
            timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(timer / 60);
            int seconds = Mathf.FloorToInt(timer % 60);
            float milliseconds = (timer * 100) % 100; // �Ҽ���
            timerText.text = string.Format("{0:D2}:{1:D2}:{2:00}", minutes, seconds, Mathf.FloorToInt(milliseconds));
            yield return null;
        }
    }

    public void StopTimer_Cor()
    {
        if (timerCoroutine != null)
        {
            StopCoroutine(timerCoroutine); // �ڷ�ƾ ���߱�
            timerCoroutine = null; // ���� �ʱ�ȭ
        }
    }

    private void Update()
    {
        
    }


}
