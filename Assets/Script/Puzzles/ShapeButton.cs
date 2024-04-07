﻿using System;
using Script.Data;
using Unity.VisualScripting;
using UnityEngine;

namespace Script.Puzzles
{
    public class ShapeButton: MonoBehaviour
    {
        [SerializeField] private Shape correctShape;
        public bool IsSolved { get; private set; }
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.GetComponent<Shape>())
            {
                if (other.gameObject == correctShape.gameObject)
                {
                    Debug.Log("Right Shape");
                    IsSolved = true;
                }
                else
                {
                    Debug.Log("Wrong Shape");
                    IsSolved = false;
                }
                Events.ShapeDetected?.Invoke();
            }
        }

        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.GetComponent<Shape>())
            {
                Debug.Log("No Shape");

                IsSolved = false;
                Events.ShapeDetected?.Invoke();
            }
        }
    }
}