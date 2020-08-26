using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorMove: MonoBehaviour
{
    private Rigidbody2D rb;
    public float dirX;
    public float moveSpeed;
    public float velSalto;

    bool grounded = false;
    
    float posX;
    float posY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Guardamos la posición inicial del personaje en el primer frame en el que se ejecuta el juego.
        posX = transform.position.x;
        posY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(Vector2.up * velSalto, ForceMode2D.Impulse);
        }

        // Si se presiona la tecla R, reseteamos la posición y velocidad del personaje a su posición inicial
        if (Input.GetKeyDown(KeyCode.R)){
            transform.position = new Vector2(posX,posY);
            rb.velocity = new Vector2(0,0);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Plataforma"))
        {
            this.transform.parent = other.transform;
            grounded = true;
        }

    }

    void OnCollisionExit2D(Collision2D other)
    {
        this.transform.parent = null;
        grounded = false;
    }

}
