using System;
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
                    IsSolved = true;
                }
                else
                {
                    IsSolved = false;
                }
                Events.ShapeDetected?.Invoke();
            }
        }

        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.GetComponent<Shape>())
            {
                IsSolved = false;
                Events.ShapeDetected?.Invoke();
            }
        }
    }
}