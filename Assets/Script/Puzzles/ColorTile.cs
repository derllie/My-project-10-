using System;
using System.Collections;
using System.Collections.Generic;
using Script.Data;
using UnityEngine;
using UnityEngine.Events;

public class ColorTile : MonoBehaviour
{
    public List<Color> colors { get; set; }
    public int currentColor { get; private set; }
    private Material tileMaterial;
    

    private void Start()
    {
        tileMaterial = gameObject.GetComponent<Renderer>().material;
        tileMaterial.color = colors[currentColor];
    }

    private void ChangeColor()
    {
        
        if (currentColor == colors.Count-1)
        {
            currentColor = 0;
        }
        else
        {
            currentColor++;
        }
        tileMaterial.color = colors[currentColor];
        Events.TileChanged?.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterController>())
        {
            ChangeColor();
        }
    }
}
