using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchPlataformaVertical : MonoBehaviour
{
    public plataformaVerticalActivable plataforma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            plataforma.activada = true;
        }
    }
}
