using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class PictureController : MonoBehaviour
{
    public Texture image1;
    public Texture image2;

    public Texture[] images;
    public Texture defaultImage;
    public Material imageMaterial;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        imageMaterial.mainTexture = defaultImage;
        gameObject.tag = "Image";
    }

    public void Act()
    {
        //if (imageMaterial.mainTexture.name == image1.name)
        //{
        //    imageMaterial.mainTexture = image2;
        //}
        //else
        //{
        //    imageMaterial.mainTexture = image1;
        //}


        //if (imageMaterial.mainTexture.name.Equals(defaultImage.name))
        //{
        //    imageMaterial.mainTexture = images[0];
        //}

        if (count == images.Length)
        {
            imageMaterial.mainTexture = defaultImage;
            count = 0;
        }
        else
        {
            imageMaterial.mainTexture = images[count];
            count++;
        }


    }
}
