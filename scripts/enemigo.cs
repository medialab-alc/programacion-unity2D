using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{

    public GameObject bala;
    public float fireRate;
    float siguienteDisparo;

    // Start is called before the first frame update
    void Start()
    {
        siguienteDisparo = Time.time;
    }

    void tiempoParaDisparo()
    {
        if (Time.time > siguienteDisparo)
        {
            Instantiate(bala, transform.position, Quaternion.identity);
            siguienteDisparo = Time.time + fireRate;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            tiempoParaDisparo();
        }
    }

}
