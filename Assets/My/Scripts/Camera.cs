using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    
    public static Material skyboxMaterial;
    
    void Awake()
    {
        // ��Ƽ���� ���
        RenderSettings.skybox = skyboxMaterial;
    }

}
