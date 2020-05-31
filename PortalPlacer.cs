using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;

public class PortalPlacer : MonoBehaviour
{
    ARRaycastManager m_ARRaycastManager;

    List<ARRaycastHit> raycast_hits = new List<ARRaycastHit>();
    public GameObject portalPrefab;

    private GameObject spawnedPortal;

    // FIRST FUNCTION


    private void Awake()
    {
        m_ARRaycastManager = GetComponent<ARRaycastManager>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (m_ARRaycastManager.Raycast(touch.position, raycast_hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
            {
                Pose pose = raycast_hits[0].pose;
                if (spawnedPortal == null)
                {
                    spawnedPortal = Instantiate(portalPrefab, pose.position, Quaternion.Euler(0, 0, 0));

                    var rotationalofportal = spawnedPortal.transform.rotation.eulerAngles;
                    spawnedPortal.transform.eulerAngles = new Vector3(rotationalofportal.x, Camera.main.transform.rotation.eulerAngles.y, rotationalofportal.z);
                }
                else
                {

                    spawnedPortal.transform.position = pose.position;
                    var rotationalofportal = spawnedPortal.transform.rotation.eulerAngles;
                    spawnedPortal.transform.eulerAngles = new Vector3(rotationalofportal.x, Camera.main.transform.rotation.eulerAngles.y, rotationalofportal.z);
                }

            }

        }

    }
}
//public bool Raycast(Vector2 screenPoint, List<ARRaycastHit> hitResults, TrackableType trackableTypeMask = TrackableType.All);