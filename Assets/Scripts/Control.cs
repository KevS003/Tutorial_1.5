using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public AudioSource musicSource;//tell unity what gameobject should be playing the audio. 

    public AudioClip musicClipOne;//holds actual audio

    public AudioClip musicClipTwo;

    Animator anim;//animator variable


    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();//anim is equal to animator on gameobject.
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = musicClipOne;//sets val of source to clipOne
            musicSource.Play();//plays the clip
            anim.SetInteger("State",1);//animator is in anim and you have control over variables.
        }
        if(Input.GetKeyUp(KeyCode.W))//on letting go of key
        {
            musicSource.Stop();
            anim.SetInteger("State",0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = musicClipTwo;//sets val of source to clip2
            musicSource.Play();//plays the clip
            anim.SetInteger("State",2);
        }
        if(Input.GetKeyUp(KeyCode.R))//on letting go of key
        {
            musicSource.Stop();
            anim.SetInteger("State",0);
        }
     if (Input.GetKeyDown(KeyCode.L))
        {
          musicSource.loop = true;
         }

     if (Input.GetKeyUp(KeyCode.L))
        {
          musicSource.loop = false;
        }
    }
}
