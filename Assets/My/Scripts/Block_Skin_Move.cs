using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Skin_Move : MonoBehaviour
{
    // Start is called before the first frame update
    float rotSpeed = 50f;
    float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        time %= 360;
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
        transform.Translate(new Vector3(0, 0.00001f*Mathf.Sin(time)*500, 0));
    }
}
