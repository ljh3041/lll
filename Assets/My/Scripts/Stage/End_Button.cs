using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class End_Button : MonoBehaviour
{
    public Problem[] problems;
    public Button button;
    public Block_Set[] blocks;
    bool button_On = false;
    void Awake()
    {
        if (button != null)
        {
            button.onClick.AddListener(End_Stage);
        }
    }

    private void FixedUpdate()
    {
        if (button_On==true)
        {
            End_Stage();
        }
    }

    void End_Stage()
    {
        button_On = true;
        //problem trigger ����
        TurnOffCollider();
        Invoke("TurnOnCollider", 3);
        foreach (Block_Set block in blocks)
        {
            
            block.transform.gameObject.layer = 15;
            foreach (Transform child in block.transform)
            {
                child.gameObject.layer = 15;
            }
            block.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            block.transform.GetComponent<Rigidbody>().useGravity = false;
            block.transform.rotation = Quaternion.Euler(block.rotate_x, block.rotate_y, block.rotate_z);
            Vector3 target = new Vector3(block.pos_x, block.pos_y, block.pos_z);
            Vector3 speed = Vector3.zero;
            block.transform.position = Vector3.SmoothDamp(block.transform.position, target, ref speed, 0.1f);
        }
    }
    void TurnOffCollider()
    {
        foreach (Problem problem in problems)
        {
            problem.GetComponent<BoxCollider>().enabled = false;
        }
    }

    void TurnOnCollider()
    {
        foreach (Problem problem in problems)
        {
            problem.GetComponent<BoxCollider>().enabled = true;
        }
        button_On = false;
    }
}
