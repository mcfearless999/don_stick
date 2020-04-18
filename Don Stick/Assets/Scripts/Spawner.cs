using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] doors;
    
    public float spawnWait;
    public float minSpawnWait;
    public float maxSpawnWait;
    public float startWait;
    public Player player;
    int doorNumber;

    void Start()
    {
        
        StartCoroutine(randomSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(minSpawnWait, maxSpawnWait);
        
    }

    IEnumerator randomSpawn()
    {
        yield return new WaitForSeconds(startWait);

        while (!player.gameOver)
        {
            doorNumber = Random.Range(0, 6);
            doors[doorNumber].SetActive(true);
            
            yield return new WaitForSeconds(spawnWait);
        }
    }

}
