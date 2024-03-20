using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] CarPrefabs;
    float SpawnRangeX = 20;
    float spawnPosZ = 35;
    public float startingSpawn = 5; 
    public float spawnTiming = 1.5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startingSpawn, spawnTiming);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomCar()

    {
        int carGenerator = Random.Range(1,2);

        if (carGenerator == 1)
        {
           Vector3 spawnPos = new Vector3(5, 0, 183); 
            
            int carIndex = Random.Range(0, CarPrefabs.Length); 
            
            Instantiate(CarPrefabs[carIndex], spawnPos, CarPrefabs[carIndex].transform.rotation);
        }
        
        if (carGenerator == 2)
        {
            Vector3 spawnPos = new Vector3(-6, 0, 183); 
            
            int carIndex = Random.Range(0, CarPrefabs.Length); 
            
            Instantiate(CarPrefabs[carIndex], spawnPos, CarPrefabs[carIndex].transform.rotation);
        }
    }
}
