using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    public static BackGround Instance;
    [SerializeField] private Sprite[] BackGroundSprite;
    [SerializeField] private Image BackGroundImage;
    [SerializeField] private Material[] BackGroundMaterial;
    public Material GetBackGround => this.BackGroundMaterial[index];
    public int index = 0;

    void Awake()
    {
        Instance = this;
    }

    public void ChangeBackGroundImage()
    {
        index++;
        index %= BackGroundMaterial.Length;
        BackGroundImage.sprite = BackGroundSprite[index];

    }

    public void SelectBackGroundImage()
    {
        Camera.Instance.skyboxMaterial = BackGroundMaterial[index];
        Camera.Instance.ChangeSkybox();
    }

}
