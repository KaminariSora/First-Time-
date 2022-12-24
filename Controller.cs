using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private Animator anim ;
    private Rigidbody2D rb;
    public Vector2 movement ;
    public float speed = 10.0f ;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.J))
        {
            anim.SetBool("Attack",true);
        }
        else
        {
            anim.SetBool("Attack",false);
        }
        if(Input.GetKey(KeyCode.K))
        {
            anim.SetBool("Attack2",true);
        }
        else
        {
            anim.SetBool("Attack2",false);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isRunningR",true);
        }
        else
        {
            anim.SetBool("isRunningR",false);
        }
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
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("congratulations");
        }
    }
}
