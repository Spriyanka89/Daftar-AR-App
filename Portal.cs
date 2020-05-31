using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class Portal : MonoBehaviour
{
    public Material[] materials;


    void Start()
    {

        foreach (var mat in materials)
        {
            mat.SetInt("stest", (int)CompareFunction.Equal);

        }

    }

    void Update()
    {

    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.tag != "MainCamera")
        {
            return;
        }


        Vector3 user_position = Camera.main.transform.position + Camera.main.transform.forward * Camera.main.nearClipPlane;
        Vector3 relativePosition = transform.InverseTransformPoint(user_position);

        //outside

        if (transform.position.z > collider.transform.position.z)
        {


            foreach (var mat in materials)
            {
                mat.SetInt("stest", (int)CompareFunction.Equal);

            }
        }


        //inside

        else
        {

            foreach (var mat in materials)
            {
                mat.SetInt("stest", (int)CompareFunction.NotEqual);

            }

        }

    }

}
