using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeRespawn : MonoBehaviour
{
    public float threshold;
    private Vector3 initPosition;

    private void Start()
    {
        initPosition = gameObject.transform.position;
    }

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            transform.position = initPosition;
        }
    }
}
