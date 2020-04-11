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
    public int rabbitCount;
    private GameObject[] rabbits;

    public GameObject[,] GenerateMap(MapGenerator mapGen) {
        return mapGen.CreateMap(mapWidth, mapHeight, waterChance);
    }

    public GameObject[] AnimalSpawner(int specieCount, GameObject specie) {
        return mapGen.SpawnAnimal(specieCount, specie, this.map);
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

        this.mapGen = gameObject.GetComponent<MapGenerator>();
        this.map = GenerateMap(mapGen);
        this.rabbits = AnimalSpawner(this.rabbitCount, this.rabbit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
