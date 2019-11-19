using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupsSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    public string tag1, tag2, tag3, tag4, tag5, tag6, tag7;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    int whatToSpawn;
    float x, y, z;
    Vector3 pos;

    private GameObject hold;


    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 8);
            //Debug.Log(whatToSpawn);

            x = Random.Range(-19, 19);
            y = Random.Range(-12, 12);
            z = 0;
            pos = new Vector3(x, y, z);

            switch (whatToSpawn)
            {
                case 1:
                    hold = objectPooler.SpawnFromPool(tag1, pos, Quaternion.identity);
                    hold.SetActive(true);
                    break;
                case 2:
                    hold = objectPooler.SpawnFromPool(tag2, pos, Quaternion.identity);
                    hold.SetActive(true);
                    break;
                case 3:
                    hold = objectPooler.SpawnFromPool(tag3, pos, Quaternion.identity);
                    hold.SetActive(true);
                    break;
                case 4:
                    hold = objectPooler.SpawnFromPool(tag4, pos, Quaternion.identity);
                    hold.SetActive(true);
                    break;
                case 5:
                    hold = objectPooler.SpawnFromPool(tag5, pos, Quaternion.identity);
                    hold.SetActive(true);
                    break;
                case 6:
                    hold = objectPooler.SpawnFromPool(tag6, pos, Quaternion.identity);
                    hold.SetActive(true);
                    break;
                case 7:
                    hold = objectPooler.SpawnFromPool(tag7, pos, Quaternion.identity);
                    hold.SetActive(true);
                    break;
            }
            nextSpawn = Time.time + spawnRate;
        }
    }
}

