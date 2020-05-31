using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{//our conversation also copied, these comments
    public AudioClip clip; //initial image,  consider it as cd
    public AudioSource source; //  this component play the audio clip, so its a player// cd player
    // Start is called before the first frame update // you are drinking
    void Start()
    {
        gameObject.tag = "MusicPic";
    }

    public void Act()
    {
        //What should I do here ? just  play music or also stop it
        //Do you want the sound to be 3d like when go close to the image you hear the sound? ofcourse with tap
        if (source.isPlaying)
        {
            source.Stop(); // yeah, 
            // in a way yes
        }
        else
        {
            source.PlayOneShot(clip);
        }
    }
}
