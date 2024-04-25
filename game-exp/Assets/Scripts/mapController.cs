using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(20,0, 0), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(20, 0, 0);
                SpawnChunk();            
            }    
            
            // строка выше проверяет есть ли чанк на расстоянии от плеера справа -_- даня еще один деьн по 12 часов этой ##### и я кого-нибудь за##### /cvtmslf
        }

        else if (pm.direction.x < 0 && pm.direction.y == 0) // left
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(-20, 0, 0), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(-20, 0, 0);
                SpawnChunk();
            }
        }

        else if (pm.direction.x == 0 && pm.direction.y > 0) // up
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(0, 20, 0), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(00, 20, 0);
                SpawnChunk();
            }

        }

        else if (pm.direction.x == 0 && pm.direction.y < 0) // down
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(0, -20, 0), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(0, -20, 0);
                SpawnChunk();
            }

        }
        else if (pm.direction.x > 0 && pm.direction.y > 0) // right up
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(20, 20, 0), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(20, 20, 0);
                SpawnChunk();
            }

        }
        else if (pm.direction.x > 0 && pm.direction.y < 0) // right down
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(20, -20, 0), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(20, -20, 0);
                SpawnChunk();
            }

        }
        else if (pm.direction.x < 0 && pm.direction.y > 0) // left up
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(-20, 20, 0), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(-20, 20, 0);
                SpawnChunk();
            }

        }
        else if (pm.direction.x < 0 && pm.direction.y < 0) // left down
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(-20, -20, 0), checkerRadius, terrainMask))
            {
                noTerrainPosition = player.transform.position + new Vector3(-20, -20, 0);
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

