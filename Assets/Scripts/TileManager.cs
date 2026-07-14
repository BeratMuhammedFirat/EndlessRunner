using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public List<Transform> tiles = new List<Transform>();
    public float tileLenght = 96f;


    public void MoveTile()
    {
        Transform firstTile = tiles[0];
        Transform lastTile = tiles[tiles.Count - 1];

        firstTile.position = lastTile.position + (Vector3.forward * tileLenght);        
        
        tiles.RemoveAt(0);
        tiles.Add(firstTile);
    }
}
