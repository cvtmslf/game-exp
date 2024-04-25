using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject>();
    public float spawnRate;
    private float x, y;
    private int z;
    private Vector3 spawnPos;
    void Start()
    {
        StartCoroutine(SpawnTestEnemy());
    }
    IEnumerator SpawnTestEnemy()
    {
        x = Random.Range(-10, 10);
        y = Random.Range(-10, 10);
        z = -1;
        spawnPos.x += x;
        spawnPos.y += y;
        spawnPos.z = z;
        Instantiate(Enemies[0], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(spawnRate);
        StartCoroutine(SpawnTestEnemy());
    }
    
    
    

}
