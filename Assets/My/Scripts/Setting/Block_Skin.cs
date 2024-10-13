using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Block_Skin : MonoBehaviour
{
    public static Block_Skin Instance;
    [SerializeField] private Sprite[] Block_Skin_Image;
    [SerializeField] private Material[] BlockSkinMaterial;
    [SerializeField] private Block block;
    [SerializeField] private Image SkinImage;
    public Material GetBlockSkin => this.BlockSkinMaterial[index];
    private int index = 0;
    void Awake()
    {
        Instance = this;

        SkinImage.sprite = Block_Skin_Image[index];
        block.gameObject.GetComponent<MeshRenderer>().material =
            BlockSkinMaterial[index];
    }


    public void ChangeBlockSkin()
    {
        index++;
        index %= Block_Skin_Image.Length;
        SkinImage.sprite = Block_Skin_Image[index];
    }
    public void SelectBlockSkin()
    {
        block.gameObject.GetComponent<MeshRenderer>().material =
            BlockSkinMaterial[index];
    }
}
