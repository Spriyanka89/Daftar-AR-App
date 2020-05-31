using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]

public class PictureControl : MonoBehaviour
{
    public Texture image1; //initial image
    public Texture image2;
    

    public Material imageMaterial;
    // Start is called before the first frame update
    void Start()
    {

        imageMaterial.mainTexture = image1; //Assign initial image to material onStart.. this is reset, yes because if it the image is changes in previous run it will assign the original
        gameObject.tag = "Image";
    }

    public void Act()
    {
        if (imageMaterial.mainTexture.name == image1.name)//compare the name
        {//It says that if the current image name is equal to the image 1 than it assign the second image
            imageMaterial.mainTexture = image2; // did you get it? yes, it has image1 or image2 based on thta it will assign the image no
        }
        else
        {
            imageMaterial.mainTexture = image1;
        }

    }
}

