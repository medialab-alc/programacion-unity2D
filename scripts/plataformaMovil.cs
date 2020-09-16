using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaMovil : MonoBehaviour
{
    Vector3 posicionInicial = new Vector3(0,0,0);
    public Vector3 velocidad = new Vector3(0,0,0);
    public float distanciaX;
    public float distanciaY;


    // La función Start se ejecuta una vez antes del primer frame del juego
    void Start()
    {
        posicionInicial = gameObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movimiento de la plataforma
        transform.Translate(velocidad * Time.deltaTime);

        //Condiciones de cambio de sentido
        if (gameObject.transform.position.x > posicionInicial.x + distanciaX){
            velocidad.x = velocidad.x * -1;
        }
        if (gameObject.transform.position.x < posicionInicial.x){
            velocidad.x = velocidad.x * -1;
        }
        if (gameObject.transform.position.y > posicionInicial.y + distanciaY){
            velocidad.y = velocidad.y * -1;
        }
        if (gameObject.transform.position.y < posicionInicial.y){
            velocidad.y = velocidad.y * -1;
        } 

    }

}
