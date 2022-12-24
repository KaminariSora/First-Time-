using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingPLayer : MonoBehaviour
{
    public GameObject player;
    public float speed ;
    private float distance ;
    void Start()
    {
        
    }
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position ;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y , direction.x) * Mathf.Rad2Deg ;

        if (distance < 0)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position ,speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
