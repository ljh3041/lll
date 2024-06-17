using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Select_Bgm : MonoBehaviour
{
    public Button button;
    public Bgm_Box bgm_box;
    void Awake()
    {
        if (button != null)
        {
            button.onClick.AddListener(Change_Bgm);
        }
    }



    void Change_Bgm()
    {
        bgm_box.index++;
        bgm_box.index %= 4;
        bgm_box.BGMPlay(bgm_box.index);
    }
}
