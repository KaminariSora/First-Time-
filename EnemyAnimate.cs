using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimate : MonoBehaviour
{
    private Animator anim ;
    private Rigidbody2D rb;
    public Vector2 movement ;
    public float speed = 10.0f ;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isRunningL",true);
        }
        else
        {
            anim.SetBool("isRunningL",false);
        }
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
