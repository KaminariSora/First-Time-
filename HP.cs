using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] private int hp = 100;

    private int MAX_hp = 100;

    void update(){
        if(Input.GetKeyDown(KeyCode.O)){
            Damage(10);
        }
        if(Input.GetKeyDown(KeyCode.P)){
            Heal(10);
        }

    }

    public void Damage(int amount){
        if(amount < 0){
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.hp -= amount;

        if(hp <= 0){
            Die();
        }
    }

    public void Heal(int amount){
        if(amount < 0 ){
            throw new System.ArgumentOutOfRangeException("Can not have negative healing");
        }
        
        bool wouldBeOverMaxhp = hp + amount > MAX_hp;

        if(wouldBeOverMaxhp){
            this.hp = MAX_hp;
        }
        else{
            this.hp += amount;
        }
    } 

    private void Die(){
        Debug.Log("I am Dead");
        Destroy(gameObject);
    }       
}