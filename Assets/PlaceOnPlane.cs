using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class PlaceOnPlane : MonoBehaviour {
    public GameObject pyramidPrefab;
    private ARRaycastManager rayManager;
    private GameObject spawnedObject;


    void Awake() {
        rayManager = GetComponent<ARRaycastManager>();
    }

    void Update() {
        if (Input.touchCount > 0 && spawnedObject == null) {
            Vector2 touchPos = Input.GetTouch(0).position;
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            if (rayManager.Raycast(touchPos, hits, TrackableType.PlaneWithinPolygon)) {
                Pose hitPose = hits[0].pose;
                spawnedObject = Instantiate(pyramidPrefab, hitPose.position, hitPose.rotation);
            }
        }
    }
}
