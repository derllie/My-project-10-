using System;
using System.Collections;
using System.Collections.Generic;
using Script.Data;
using Script.Puzzles;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.PlayerLoop;

public class ColorTilesPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject objectToShow;
    [SerializeField] private List<TileColorPair> tiles;
    [SerializeField] private List<Color> colors;
    
    private void Start()
    {
        objectToShow.SetActive(false);
        foreach (var tile in tiles)
        {
            tile.ColorTile.colors = colors;
        }
        Events.TileChanged += ShowBridge;
    }
    public void ShowBridge()
    {
        if (CheckIfSolved())
        {
            
            objectToShow.SetActive(true);
        }
    }

    public bool CheckIfSolved()
    {
        foreach (var tile in tiles)
        {
            if (tile.ColorTile.currentColor != tile.CorrectColor)
            {
                return false;
            }
        }
        return true;
    }
}
