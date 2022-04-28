using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    private Camera _camera;

 
    private float _zoomStep = 2;
    private Vector3 _origin;

    
    private void Update()
    {
        MoveCamera();
        ZoomCamera();
    }


    private void MoveCamera()
    {
        //save the position of the mouse when it first clicks
        if (Input.GetMouseButtonDown(0))
        {
            _origin = _camera.ScreenToWorldPoint(Input.mousePosition);
        }

        //calculate distance between the origin and where mouse is now and move the camera accordingly
        if(Input.GetMouseButton(0))
        {
            var distance = _origin - _camera.ScreenToWorldPoint(Input.mousePosition);
            _camera.transform.position += distance;
        }
    }

    private void ZoomCamera()
    {
        _camera.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * _zoomStep;
    }
}
