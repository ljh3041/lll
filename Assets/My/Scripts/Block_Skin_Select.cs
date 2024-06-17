using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Block_Skin_Select : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public Block_Skin[] block_skin;
    public Block block;
    public Global_Setting global_Setting;
    public int index;
    void Awake()
    {
        if (button != null)
        {
            button.onClick.AddListener(Select_Skin_Picture);
        }
    }



    void Select_Skin_Picture()
    {
        block.gameObject.GetComponent<MeshRenderer>().material = block_skin[index].BlockSkinMaterial;
        global_Setting.index = index;
    }
}
