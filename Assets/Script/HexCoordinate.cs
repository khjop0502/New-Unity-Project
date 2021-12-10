using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCoordinate : MonoBehaviour
{
    public static GameObject[,] _coordinateArr;
    private static Vector2 mapSize;

    void Awake()
    {
        
    }
    public static GameObject[,] CoordinateArr
    {
        get
        {
            if (_coordinateArr.Length == 0)
            {
                _coordinateArr = new GameObject[(int)mapSize.x, (int)mapSize.y * 2];
            }
            return _coordinateArr;
        }
    }
}
