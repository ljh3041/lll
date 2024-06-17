using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Block_Skin : MonoBehaviour
{
    public Material BlockSkinMaterial;
    public Button button;
    public Block_Skin_Select block_Skin_Select;
    void Awake()
    {
        if (button != null)
        {
            button.onClick.AddListener(Change_Next_Skin_Picture);
        }
    }



    void Change_Next_Skin_Picture()
    {
        block_Skin_Select.index++;
        block_Skin_Select.index %=4;
    }
}
