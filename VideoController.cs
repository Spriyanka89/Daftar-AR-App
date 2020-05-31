using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class VideoController : MonoBehaviour
{
    VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Video";
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void Act()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
        else
        {
            videoPlayer.Play();
        }
    }
}
