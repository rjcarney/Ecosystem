using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    // Size of map
    private int width;
    private int height;

    public GameObject tile;

    public void CreateMap(int width, int height) {
        this.width = width;
        this.height = height;

        for (int x = 0; x < this.width; x++) {
            for (int z = 0; z < this.height; z++) {
                Instantiate(tile, new Vector3(x*2, 0, z*2), Quaternion.identity);
            }
        }
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
