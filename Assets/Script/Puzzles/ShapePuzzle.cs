using System;
using System.Collections.Generic;
using System.Linq;
using Script.Data;
using UnityEngine;

namespace Script.Puzzles
{
    public class ShapePuzzle : MonoBehaviour
    {
        [SerializeField] private List<ShapeButton> buttons;
        [SerializeField] private GameObject objectToShow;
        private bool objectActive; 
        private void Start()
        {
            objectToShow.SetActive(false);
        }

        private void Update()
        {
            if (!objectActive)
            {
                if (IsSolved())
                {
                    Debug.Log("solved");
                    AudioManager.instance.PlaySFX("NewLevel");
                    objectToShow.SetActive(true);
                    objectActive = true;
                }
            }
            
        }

        private bool IsSolved()
        {
            return buttons.All(button => button.IsSolved);
        }
    }
}