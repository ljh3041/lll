using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem : MonoBehaviour
{
    public bool AlreadyIn;
    public string AlreadyInBlockSetName;
    private MeshRenderer meshRenderer;
    public AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            if (AlreadyIn == false)
            {
                SoundPlay();
                GameManager.Instance.StagePoint += 1;
                AlreadyIn = true;
                AlreadyInBlockSetName = collision.gameObject.transform.parent.name;
            }
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Block" && collision.gameObject.transform.parent.name == AlreadyInBlockSetName)
        {
            GameManager.Instance.StagePoint -= 1;
            AlreadyIn = false;
        }
    }


    void SoundPlay()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
