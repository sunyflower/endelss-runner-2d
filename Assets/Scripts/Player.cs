using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    //zbiera sie component rigbody
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // sterowanie w gore, w dol, ustawienia direction
    void Update()
    {

        float directionY = Input.GetAxis("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;

    }


    // ustawianie velocity 
    private void FixedUpdate()
    {

        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);

    }
}
