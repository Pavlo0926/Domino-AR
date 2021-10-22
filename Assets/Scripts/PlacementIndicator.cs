using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicator : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private GameObject visual;

    // Start is called before the first frame update
    void Start()
    {
        raycastManager = FindObjectOfType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;


        visual.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        raycastManager.Raycast(Camera.current.ViewportToScreenPoint(new Vector3(0.5f,0.5f)), hits, TrackableType.Planes);

        if(hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;



            if(!visual.activeInHierarchy)
            {
                visual.SetActive(true);
            }
        }
    }
}
