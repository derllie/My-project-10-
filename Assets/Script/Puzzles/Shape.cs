using UnityEngine;

namespace Script.Puzzles
{
    public class Shape : MonoBehaviour
    {
        [SerializeField] private ShapeType shapeType;
    }

    public enum ShapeType
    {
        Diamond,
        Heart,
        Star,
        Gem
    }
}