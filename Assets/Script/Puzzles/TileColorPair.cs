using UnityEngine;

namespace Script.Puzzles
{
    [System.Serializable]
    public class TileColorPair
    {
        [field:SerializeField] public ColorTile ColorTile { get; set; }
        [field:SerializeField] public int CorrectColor { get; set; }
    }
}