using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    float velocidad = 7f;
    Rigidbody2D rb;
    GameObject objetivo;
    Vector2 direccion;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        objetivo = GameObject.FindGameObjectWithTag("Player");
        direccion = (objetivo.transform.position - transform.position).normalized * velocidad;
        rb.velocity = new Vector2(direccion.x, direccion.y);
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("ouch");
            Destroy(gameObject);
        }
    }

}
