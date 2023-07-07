using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{



    private void Update()
    {
       // Destroy(gameObject, 4);
    }

 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyBerhaviour enemy = collision.gameObject.GetComponent<EnemyBerhaviour>();
            enemy.TakeDamage(10);
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "Car")
        {
            Debug.Log("Calling car");
            collision.gameObject.GetComponent<ObejctDestructionScript>().takeDamage(10);
           
            Destroy(gameObject);

        }
    }

    
}
