using System;
using System.Collections.Generic;
using Script.Data;
using UnityEngine;

namespace Script.Puzzles
{
    public class ShapePuzzle : MonoBehaviour
    {
        [SerializeField] private List<ShapeButton> buttons;
        [SerializeField] private GameObject objectToShow;
        private void Start()
        {
            Events.ShapeDetected += MakeAction;
            objectToShow.SetActive(false);
        }

        private void MakeAction()
        {
            if (IsSolved())
            {
                objectToShow.SetActive(true);
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