using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class InteractionController : MonoBehaviour
{
    public Camera MainCamera;
    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        //SetDominoObject();
        MainCamera = Camera.main;
    }
    private void Update()
    {
        ray = MainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {

            if (Input.GetMouseButtonDown(0))
            {
                print(hit.transform.gameObject.name);
                if (hit.transform.gameObject.CompareTag("Video"))
                {
                    hit.transform.GetComponent<VideoController>().Act();
                }
                if (hit.transform.gameObject.CompareTag("Image"))
                {
                    hit.transform.GetComponent<PictureController>().Act();
                }
                if (hit.transform.gameObject.CompareTag("MusicPic"))
                {
                    hit.transform.GetComponent<MusicController>().Act();
                }

            }
        }
    }

}

