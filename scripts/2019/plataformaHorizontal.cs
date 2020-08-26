using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaHorizontal: MonoBehaviour
{

    public float velocidad;
    public float desplazamiento;

    float positionX;
    float positionY;

    bool moveRight = true;
    bool moveUp = true;

    
    void Start()
    {
        positionX = gameObject.transform.position.x;
        positionY = gameObject.transform.position.y;
    }

    void FixedUpdate()
    {
        if (transform.position.x > positionX + desplazamiento){
            moveRight = false;
        }
        if (transform.position.x <= positionX){
            moveRight = true;
        }

        if (transform.position.y > positionY + desplazamiento){
            moveUp = false;
        }
        if (transform.position.y <= positionY){
            moveUp = true;
        }

        if (moveRight){
            transform.position = new Vector2(transform.position.x + velocidad * Time.deltaTime, transform.position.y);
        }
        if (!moveRight){
            transform.position = new Vector2(transform.position.x - velocidad * Time.deltaTime, transform.position.y);
        }
    }
}
