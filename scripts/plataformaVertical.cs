using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaVertical: MonoBehaviour
{
    public float velocidad;
    public float desplazamiento;

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
        if (transform.position.x > positionX + desplazamiento)
        {
            moveRight = false;
        }
        if (transform.position.x < positionX)
        {
            moveRight = true;
        }

        if (transform.position.y > positionY + desplazamiento)
        {
            moveUp = false;
        }
        if (transform.position.y < positionY)
        {
            moveUp = true;
        }

        if (moveUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + velocidad * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - velocidad * Time.deltaTime);
        }


    }
}
