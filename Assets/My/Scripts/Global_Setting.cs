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

        // �ν��Ͻ��� �̹� �ִ� ��� ������Ʈ ����
        else if (instance != this)
        {
           
            this.index = instance.index;
            
            Destroy(this);
        }
        // �̷��� �ϸ� ���� scene���� �Ѿ�� ������Ʈ�� ������� �ʽ��ϴ�.
        DontDestroyOnLoad(instance);
        
    }
    


}
