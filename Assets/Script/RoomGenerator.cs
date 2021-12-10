using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    public Vector2 roomSize;
    public GameObject tilePrefeb;
    [Range(0,1)]
    public float outlinePercent;
    public void GenerateRoom()
    {
        
        string holderName = "Generated Room";
        if (transform.Find(holderName))
        {
            DestroyImmediate(transform.Find(holderName).gameObject);
        }
        Transform roomHolder = new GameObject(holderName).transform;
        roomHolder.parent = transform;
        for (int x = 0; x < roomSize.x; x++)
        {
            for (int y = x % 2; y < roomSize.y * 2; y += 2)
            {
                GameObject newCoordinatePoint = Instantiate(tilePrefeb);
                Debug.Log(HexCoordinate.coordinateArr[x, y]);
                newCoordinatePoint.transform.position = temp[x,y].transform.position;
                newCoordinatePoint.transform.parent = roomHolder;
            }
        }
    }
}
