using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;



    // wyszukiwanie obiektu o nazwie player
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    //niszczenie obiektów wrogów po wejsciu w bordera oraz niszczenie gracza
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")

        {
            Destroy(this.gameObject);   
        }

        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }

    }


}
