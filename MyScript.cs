using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    public Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        movement = new Vector2(x,y);
    }
    public void FixedUpdate()
    {
        movePlayer(movement);
    }
    void movePlayer(Vector2 direction)
    {
        rb.velocity = direction * speed ;
    }
}
