using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    // Size of map
    private int width;
    private int height;

    public GameObject tile;
    public Material grassMat;
    public Material waterMat;

    public GameObject[,] CreateMap(int width, int height, float waterChance) {
        GameObject map = new GameObject("Map");
        
        this.width = width;
        this.height = height;

        GameObject[,] mapMatrix = new GameObject[this.width, this.height];
        for (int x = 0; x < width; x++) {
            for (int z = 0; z < height; z++) {
                GameObject mapTile = CreateTile(x, z, waterChance);
                mapTile.transform.parent = map.transform;
                mapMatrix[x, z] = mapTile;
            }
        }

        return mapMatrix;
    }

    public GameObject CreateTile(int x, int z, float waterChance) {
        GameObject mapTile = Instantiate(tile, new Vector3(x * tile.transform.localScale.x, 0, z * tile.transform.localScale.z), Quaternion.identity);
        Tile tileSettings = mapTile.GetComponent<Tile>();
        tileSettings.setX(x);
        tileSettings.setZ(z);

        if (Random.Range(0f, 1f) < waterChance)
            tileSettings.setWater();
        else
            tileSettings.setLand();

        mapTile.GetComponent<MeshRenderer>().material = tileSettings.isLand() ? grassMat : waterMat;
        mapTile.tag = tileSettings.isLand() ? "Land" : "Water";

        return mapTile;
    }

    public GameObject[] SpawnAnimal(int animalCount,GameObject animal, GameObject[,] mapMatrix) {
        GameObject[] animals = new GameObject[animalCount];
        for(int a = 0; a < animalCount; a++) {
            int x = Random.Range(0, this.getWidth());
            int z = Random.Range(0, this.getHeight());
            while(mapMatrix[x, z].GetComponent<Tile>().isOccupied() || !mapMatrix[x, z].GetComponent<Tile>().isLand()) {
                x = Random.Range(0, this.getWidth());
                z = Random.Range(0, this.getHeight());
            }
            GameObject newAnimal = Instantiate(animal, new Vector3(x * 2, animal.transform.position.y, z * 2), Quaternion.identity);
            newAnimal.transform.parent = mapMatrix[x, z].transform;
            animals[a] = newAnimal;
        }
        return animals;
    }

    public int getWidth() { return this.width; }
    public int getHeight() { return this.height; }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
