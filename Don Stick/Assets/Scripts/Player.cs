using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public bool gameOver;
    public GameObject spawn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            gameOver = true;
            spawn.SetActive(false);
            FindObjectOfType<GameManager>().GameOver();

        }
    }


}
