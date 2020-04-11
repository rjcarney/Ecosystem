using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private MapGenerator mapGen;
    private GameObject[,] map;
    public int mapWidth;
    public int mapHeight;
    public float waterChance;

    public GameObject rabbit;
    public int rabitCount;

    public GameObject[,] GenerateMap() {
        mapGen = gameObject.GetComponent<MapGenerator>();
        return mapGen.CreateMap(mapWidth, mapHeight, waterChance);
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
        this.map = GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
