using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropRandomizer : MonoBehaviour
{
    public List<GameObject> propSpawnPoint;
    public List<GameObject> propPrefabs; 

    void Start()
    {
        spawnProps(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnProps()
    {
        foreach(GameObject sp in propSpawnPoint)
        {
            int rand = Random.Range(0, propPrefabs.Count);
            Instantiate(propPrefabs[rand], sp.transform.position, Quaternion.identity);
        }
    }

}
