using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward_Movement : MonoBehaviour
{
    public float movement;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(movement, 0);
        GameObject.Destroy(this.gameObject, 6f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shark")
        {
            Destroy(this.gameObject);
        }
    }
   
}
