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
    [SerializeField] private List<TileColorPair> tiles;
    [SerializeField] private List<Color> colors;
    
    private void Start()
    {
        foreach (var tile in tiles)
        {
            tile.ColorTile.colors = colors;
        }
        Events.TileChanged += Debug;
    }
    public void Debug()
    {
        if (CheckIfSolved())
        {
            UnityEngine.Debug.Log("Solved");
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
