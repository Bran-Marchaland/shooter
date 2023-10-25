using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "hitbox")
        {
            Destroy(gameObject);
        }
           
    }

}
