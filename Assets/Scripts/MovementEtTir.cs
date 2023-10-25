using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;
    public Rigidbody2D monRigidbody;
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right*speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, parent.position, parent.rotation);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed;
        }




        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bordureJoueur")
        {
            monRigidbody.velocity = monRigidbody.velocity * (0);
        }
    }
}
