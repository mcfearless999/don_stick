using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Player player;
    public float timer;
    public int waitingTime;
    // Start is called before the first frame update
   
    void Start()
    {
        gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > waitingTime)
        {
            Shoot();
            timer = 0;
        }
       
    }
    void OnMouseDown()
    {
        if(!player.gameOver)
            gameObject.SetActive(false);
    }
    

    void Shoot()
    {
        if (player.health > 0)
            player.health = player.health - 1;
    }
}
