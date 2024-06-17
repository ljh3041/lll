using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_Setting : MonoBehaviour
{
    // Start is called before the first frame update
    public static Global_Setting instance = null;
    public Material[] BlockSkinMaterial;
    public int index;
    void Awake()
    {

        if (instance == null)
            instance = this;

        // 인스턴스가 이미 있는 경우 오브젝트 제거
        else if (instance != this)
        {
           
            this.index = instance.index;
            
            Destroy(this);
        }
        // 이렇게 하면 다음 scene으로 넘어가도 오브젝트가 사라지지 않습니다.
        DontDestroyOnLoad(instance);
        
    }
    


}
