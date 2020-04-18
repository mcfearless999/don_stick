using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    // Start is called before the first frame update
    public Player player;
    void Start()
    {
        gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(Shoot());
    }
    void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    IEnumerator Shoot()
    {
       

        while (!player.gameOver)
        {
            yield return new WaitForSeconds(10);
            player.health = player.health - 1;
        }
    }
}
