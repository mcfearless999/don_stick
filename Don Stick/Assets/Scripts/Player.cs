using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public bool gameOver;
    public Spawner spawner;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            gameOver = true;
            spawner.SetActive(false);
        }
    }


}
