using System;
using UnityEngine;

public class CameraZoom : MonoBehaviour{
    [SerializeField] private Camera cam;
    [SerializeField] private float zoomStep, minCamSize, maxCamSize;

    private Vector3 dragOrigin;
    private void Update(){
        PanCamera();
    }

    private void PanCamera(){
        if (Input.GetMouseButtonDown(0)){
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0)){
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);
            
            cam.transform.position += difference;
        }
    }

    public void ZoomIn(){
        float newSize = cam.orthographicSize - zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
    }

    public void ZoomOut(){
        float newSize = cam.orthographicSize + zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
    }
}