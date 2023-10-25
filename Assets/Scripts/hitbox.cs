using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox : MonoBehaviour
{
    public Rigidbody2D monRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        monRigidbody.AddForce(new Vector2(100f,0));
    }

    // Update is called once per frame
    void Update()
    {

       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bordure")
        {
            monRigidbody.velocity=monRigidbody.velocity*(-1);
        }

    }
}
