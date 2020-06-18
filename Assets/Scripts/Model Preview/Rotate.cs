﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour 
{
    [SerializeField, Tooltip("Enable this if you want it to be rotating in a single direction.")]
    private bool _isModelPreview;
    [SerializeField, Tooltip("Enable this if the object is being inspected by a player. this enables free movement.")]
    private bool _isPlayerPreview;

    [SerializeField]
    private float _rotationSpeed = 15f;
    private float _maxZoomIn;
    private float _maxZoomOut;

    private void Update() 
    {
        if (_isModelPreview) 
        {
            RotateModel();
        }
    }

    private void RotateModel() 
    {
        //Debug.Log("Rotate");
        transform.Rotate(Vector3.up * Time.deltaTime * _rotationSpeed);
    }
}
