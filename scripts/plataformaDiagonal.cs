using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaDiagonal : MonoBehaviour
{
    public float velocidadX;
    public float velocidadY;
    public float desplazamientoX;
    public float desplazamientoY;

    float positionX;
    float positionY;

    bool moveRight = true;
    bool moveUp = true;

    void Start()
    {
        positionX = transform.position.x;
        positionY = transform.position.y;
    }

    void FixedUpdate()
    {
        if (transform.position.x > positionX + desplazamientoX)
        {
            moveRight = false;
        }
        if (transform.position.x < positionX)
        {
            moveRight = true;
        }

        if (transform.position.y > positionY + desplazamientoY)
        {
            moveUp = false;
        }
        if (transform.position.y < positionY)
        {
            moveUp = true;
        }

        if (moveUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + velocidadY * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - velocidadY * Time.deltaTime);
        }
        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + velocidadX * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - velocidadX * Time.deltaTime, transform.position.y);
        }

    }
}
