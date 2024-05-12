using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{

    public List<GameObject> terrainChunks;
    public GameObject player;
    public float checkerRadius;
    Vector2 noTerrainPosition;
    public LayerMask terrainMask;
    PlayerMovement pm;
    public GameObject currentChunk;

    void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
    }


    void Update()
    {
        ChunkChecker();
    }




    void ChunkChecker()
    {   
        if (!currentChunk)
        {
            return;
        }    


        if (pm.direction.x > 0 && pm.direction.y == 0) //right
        {
            if (!Physics2D.OverlapCircle(currentChunk.transform.Find("right").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("right").position;
                SpawnChunk();            
            }    
            
            // строка выше проверяет есть ли чанк на расстоянии от плеера справа -_- даня еще один деьн по 12 часов этой ##### и я кого-нибудь за##### /cvtmslf
        }

        else if (pm.direction.x < 0 && pm.direction.y == 0) // left
        {
            if (!Physics2D.OverlapCircle(currentChunk.transform.Find("left").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("left").position;
                SpawnChunk();
            }
        }

        else if (pm.direction.x == 0 && pm.direction.y > 0) // up
        {
            if (!Physics2D.OverlapCircle(currentChunk.transform.Find("up").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("up").position;
                SpawnChunk();
            }

        }

        else if (pm.direction.x == 0 && pm.direction.y < 0) // down
        {
            if (!Physics2D.OverlapCircle(currentChunk.transform.Find("down").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("down").position;
                SpawnChunk();
            }

        }
        else if (pm.direction.x > 0 && pm.direction.y > 0) // right up
        {
            if (!Physics2D.OverlapCircle(currentChunk.transform.Find("right up").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("right up").position;
                SpawnChunk();
            }

        }
        else if (pm.direction.x > 0 && pm.direction.y < 0) // right down
        {
            if (!Physics2D.OverlapCircle(currentChunk.transform.Find("right down").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("right down").position;
                SpawnChunk();
            }

        }
        else if (pm.direction.x < 0 && pm.direction.y > 0) // left up
        {
            if (!Physics2D.OverlapCircle(currentChunk.transform.Find("left up").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("left up").position;
                SpawnChunk();
            }

        }
        else if (pm.direction.x < 0 && pm.direction.y < 0) // left down
        {
            if (!Physics2D.OverlapCircle(currentChunk.transform.Find("left down").position, checkerRadius, terrainMask))
            {
                noTerrainPosition = currentChunk.transform.Find("left down").position;
                SpawnChunk();
            }

        }



        void SpawnChunk()
        {
            int rand = Random.Range(0, terrainChunks.Count);
            Instantiate(terrainChunks[rand], noTerrainPosition, Quaternion.identity);
        }

    }
}

