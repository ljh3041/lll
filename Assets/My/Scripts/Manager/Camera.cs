using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public static Camera Instance;
    
    public Material skyboxMaterial;
    
    void Awake()
    {
        // Singleton
        Instance = this;
    }

    private void Start()
    {
        skyboxMaterial = BackGround.Instance.GetBackGround;
        // �ʱ� ����� Skybox ����.
        RenderSettings.skybox = skyboxMaterial;
    }
    public void ChangeSkybox()
    {
        RenderSettings.skybox = skyboxMaterial;
    }
}
