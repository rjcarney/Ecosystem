using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private MapGenerator mapGen;
    public int mapWidth;
    public int mapHeight;
    public float waterChance;

    public void GenerateMap() {
        mapGen = gameObject.GetComponent<MapGenerator>();
        GameObject map = mapGen.CreateMap(mapWidth, mapHeight, waterChance);
    }

    void Awake() {
        // Make Sure Only One Game Manager Exists
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
