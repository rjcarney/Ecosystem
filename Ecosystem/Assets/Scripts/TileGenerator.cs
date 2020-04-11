using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour 
{ 
    public GameObject tile;

    private int x;
    private int z;

    private bool isLand;
    public Material grassMat;
    public Material waterMat;

    public GameObject CreateTile(int x, int z, float waterChance) {
        GameObject mapTile = Instantiate(tile, new Vector3(x * 2, 0, z * 2), Quaternion.identity);
        this.x = x;
        this.z = z;

        this.isLand = (Random.Range(0f, 1f) < waterChance) ? false : true;
        mapTile.GetComponent<MeshRenderer>().material = isLand ? grassMat : waterMat;
        mapTile.tag = isLand ? "Land" : "Water";

        return mapTile;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
