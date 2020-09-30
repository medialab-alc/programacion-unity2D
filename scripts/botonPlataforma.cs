using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonPlataforma : MonoBehaviour
{
    public plataformaActivable plataforma;
    public Sprite palancaArriba;
    public Sprite palancaAbajo;
    SpriteRenderer rend;
    bool trigger = false;

    // Start is called before the first frame update
    void Start()
    {
        // Asignamos el componente SpriteRenderer del objeto actual
        rend = gameObject.GetComponent<SpriteRenderer>();
        rend.sprite = palancaArriba;
    }
    // Update is called once per frame
    void Update()
    {
        if (trigger == true){
            if (Input.GetKeyDown(KeyCode.E))
            {
                plataforma.esperando = !plataforma.esperando;
                
                if (rend.sprite == palancaAbajo){
                    rend.sprite = palancaArriba;
                } else {
                    rend.sprite = palancaAbajo;
                } 
            } 
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag.Equals("Player")){
            trigger = true;
        }
    }
    
    void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.tag.Equals("Player")){
            trigger = false;       
        }
    }

}
