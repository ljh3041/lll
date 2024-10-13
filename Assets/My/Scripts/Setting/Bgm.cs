using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bgm : MonoBehaviour
{
    private static Bgm Instance;

    public int index;
    public TMP_Text Bgm_Index_Num;
    [SerializeField] private AudioClip[] Bgms;
    public AudioSource BGM;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            BGM.clip = Bgms[0];
            BGM.loop = true;
            BGM.volume = 0.1f;
            BGM.Play();
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        Bgm_Index_Num.text = $"BGM {index + 1}";
    }

    public void BGMPlay(int index)
    {
        BGM.clip = Bgms[index];
        BGM.loop = true;
        BGM.volume = 0.1f;
        BGM.Play();
    }

    public void Change_Bgm()
    {
        index++;
        index %= Bgms.Length;
        Bgm_Index_Num.text = $"BGM {index + 1}";
        BGMPlay(index);
    }
}
