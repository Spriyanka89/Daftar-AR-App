using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class PlanController : MonoBehaviour
{


    ARPlaneManager m_ARPlaneManager;
    public Text buttonText;




    private void Awake()
    {
        m_ARPlaneManager = GetComponent<ARPlaneManager>();
    }




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void TogglePlaneDetectionAndVisibility()

    public void TogglePlaneDetectionAndVisibility()
    {

        m_ARPlaneManager.enabled = !m_ARPlaneManager.enabled;

        if (m_ARPlaneManager.enabled)
        {
            SetAllPlanesActiveOrDeactive(true);
            GetComponent<PortalPlacer>().enabled = true;




            buttonText.text = "Stop Scanning";

        }

        else
        {

            SetAllPlanesActiveOrDeactive(false);
            GetComponent<PortalPlacer>().enabled = false;



            buttonText.text = "Start Scanning";

        }
    }

    void SetAllPlanesActiveOrDeactive(bool value)
    {

        foreach (var plane in m_ARPlaneManager.trackables)
        {
            plane.gameObject.SetActive(value);

        }



    }
}







//}


// void SetAllPlanesActiveOrDeactive(bool value)
// {
// m_ARPlaneManager.GetAllPlanes(existingPlanes);

// foreach (var plane in existingPlanes)
//{
//  plane.gameObject.SetActive(value);
//}

// }

//}//
