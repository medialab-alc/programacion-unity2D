using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caida : MonoBehaviour
{
    public float delay;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Invoke("caidaPlataforma", delay);
            Destroy(gameObject, 2f);
        }

    }

    void caidaPlataforma()
    {
        rb.isKinematic = false;
    }

}
