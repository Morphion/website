using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtModel : MonoBehaviour
{
    [SerializeField] private float turnSpeed;
    [SerializeField] private float zoomSpeed;
    private Vector3 _mouseStartPosition;
    private bool _trigger;
    [SerializeField] private Transform circleCameraController;
    private Vector3 _startCircleRotation;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (!_trigger)
            {
                _trigger = true;
                _mouseStartPosition = Input.mousePosition;
                _startCircleRotation = circleCameraController.rotation.eulerAngles;
            }
            Vector3 mousePos = Input.mousePosition;
            if (mousePos!=_mouseStartPosition)
            {
                circleCameraController.eulerAngles = _startCircleRotation - new Vector3(_mouseStartPosition.y - mousePos.y,_mouseStartPosition.x - mousePos.x,0)*turnSpeed;
            }
        }
        else
        {
            _trigger = false;
        }
    }
}
