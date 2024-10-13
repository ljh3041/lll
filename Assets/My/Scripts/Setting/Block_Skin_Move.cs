using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Skin_Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float rotationSpeed = 50f;
    
    private float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        time %= 360;
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
        transform.Translate(new Vector3(0, 0.003f*Mathf.Sin(time), 0));
    }
}
