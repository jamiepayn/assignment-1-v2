using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 2;

 

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("collision");
        if (collision.gameObject.tag == "bullet")
        {
            Debug.Log("enemy hit");
            health--;
        }
    }
}
