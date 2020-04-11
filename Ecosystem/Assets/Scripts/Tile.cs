using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private int x;
    private int z;

    private bool land;

    private bool occupied;


    public void setX(int x) { this.x = x; }
    public void setZ(int z) { this.z = z; }

    public int getX() { return this.x; }
    public int getZ() { return this.z; }

    public void setLand() { this.land = true; }
    public void setWater() { this.land = false; }
    public bool isLand() { return this.land; }

    public void setOccupied(bool o) { this.occupied = o; }
    public bool isOccupied() { return this.occupied; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
