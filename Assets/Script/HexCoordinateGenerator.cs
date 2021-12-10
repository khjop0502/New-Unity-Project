using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCoordinateGenerator : MonoBehaviour
{
    public GameObject holderPrefeb;
    public Vector2 mapSize;
    
    private void Start()
    {
        
    }
    public void GeneratedCoordinate() //
    {
        GameObject[,] temp = HexCoordinate.CoordinateArr;
        string holderName = "Generated Coordinate";
        if (transform.Find(holderName))
        {
            DestroyImmediate(transform.Find(holderName).gameObject);
        }

        Transform coordinateHolder = new GameObject(holderName).transform;
        coordinateHolder.parent = transform;
        for (int x = 0; x < mapSize.x; x++)
        {
            for (int y = x%2; y < mapSize.y*2; y+=2)
            {
                GameObject newCoordinatePoint = Instantiate(holderPrefeb);
                newCoordinatePoint.transform.position = new Vector3(-mapSize.y / 2 + 0.5f + (float)y / 2, 0, -mapSize.x / 2 + 0.5f + x * Mathf.Sqrt(3) / 2);
                coordinateArr[x, y] = newCoordinatePoint;
                newCoordinatePoint.transform.parent = coordinateHolder;
            }
        }
    }
}
