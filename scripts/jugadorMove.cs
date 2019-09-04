using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorMove: MonoBehaviour
{
    private Rigidbody2D rb;
    public float dirX;
    public float moveSpeed;
    public float velSalto;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * velSalto, ForceMode2D.Impulse);
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
        }

    }

    void OnCollisionExit2D(Collision2D other)
    {
        this.transform.parent = null;
    }

}
