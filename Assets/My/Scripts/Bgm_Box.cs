using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bgm_Box : MonoBehaviour
{
    private static Bgm_Box _instance;
    public Select_Bgm select_Bgm;

    public int index;
    public TMP_Text Bgm_Index_Num;
    public AudioClip[] Bgms;
    public AudioSource BGM;

    void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            BGM.clip = Bgms[0];
            BGM.loop = true;
            BGM.volume = 0.1f;
            BGM.Play();
        }
        
        else if (_instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        
    }

    public void BGMPlay(int index)
    {
        
        BGM.clip = Bgms[index];
        BGM.loop = true;
        BGM.volume = 0.1f;
        BGM.Play();
    }

    private void FixedUpdate()
    {
        string str = "BGM " + (index+1);
        Bgm_Index_Num.text = str;
    }
}
