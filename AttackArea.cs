using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 3;

    private void OntriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<HP>() != null)
        {
            HP hp = collider.GetComponent<HP>();
            hp.Damage(damage);
        }
    }

}
