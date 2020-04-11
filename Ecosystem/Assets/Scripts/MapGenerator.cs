using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    // Size of map
    private int width;
    private int height;

    private TileGenerator tileGen;

    public GameObject CreateMap(int width, int height, float waterChance) {
        GameObject map = new GameObject("Map");
        
        this.width = width;
        this.height = height;

        for (int x = 0; x < this.width; x++) {
            for (int z = 0; z < this.height; z++) {
                GameObject mapTile = tileGen.CreateTile(x, z, waterChance);
                mapTile.transform.parent = map.transform;
            }
        }

        return map;
    }

    // Start is called before the first frame update
    void Start()
    {
        tileGen = gameObject.GetComponent<TileGenerator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
