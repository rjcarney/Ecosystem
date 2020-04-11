using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour 
{ 
    public GameObject tile;

    private int x;
    private int z;

    public GameObject CreateTile(int x, int z) {
        this.x = x;
        this.z = z;
        return Instantiate(tile, new Vector3(x*2, 0, z*2), Quaternion.identity);
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
