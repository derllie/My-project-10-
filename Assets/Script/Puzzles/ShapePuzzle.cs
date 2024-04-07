using System;
using System.Collections.Generic;
using Script.Data;
using UnityEngine;

namespace Script.Puzzles
{
    public class ShapePuzzle : MonoBehaviour
    {
        [SerializeField] private List<ShapeButton> buttons;

        private void Start()
        {
            Events.ShapeDetected += MakeAction;
        }

        private void MakeAction()
        {
            if (IsSolved())
            {
                Debug.Log("Solved");
            }
            
        }
        private bool IsSolved()
        {
            foreach (var button in buttons)
            {
                if (!button.IsSolved)
                {
                    return false;
                }
            }
            return true;
        }
    }
}