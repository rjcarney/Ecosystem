using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private MapGenerator mapGen;
    public int mapWidth;
    public int mapHeight;
    public float waterChance;

    // Start is called before the first frame update
    void Start()
    {
        mapGen = gameObject.GetComponent<MapGenerator>();
        GameObject map = mapGen.CreateMap(mapWidth, mapHeight, waterChance);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
