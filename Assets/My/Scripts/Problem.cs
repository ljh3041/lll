using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem : MonoBehaviour
{
    public bool AlreadyIn;
    public string AlreadyInBlockSetName;
    public GameManager gameManager;
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
                //meshRenderer.materials[0].color = new Color(0, 0, 1, 0.5f);
                gameManager.StagePoint += 1;
                AlreadyIn = true;
                AlreadyInBlockSetName = collision.gameObject.transform.parent.name;
            }
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Block" && collision.gameObject.transform.parent.name == AlreadyInBlockSetName)
        {
            //meshRenderer.materials[0].color = new Color(1, 1, 1, 0.1f);
            gameManager.StagePoint -= 1;
            AlreadyIn = false;
        }
    }


    void SoundPlay()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
