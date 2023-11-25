using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;

    public Transform parent2;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;
    public Rigidbody2D monRigidbody;
    public TextMeshProUGUI monUI;
    public TextMeshProUGUI mesCoins;
    public int Coin = 0;
    public float speed = 0.1f;
    public int score = 0;
    public int scoreCoin = 0;
    public GameObject[] listepowerUP; 
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
            Instantiate(bullet, parent2.position, parent2.rotation);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed;
        }


        if (Input.GetKey(KeyCode.B) && Coin >= 20)
        {
            for (int i = 3; i < listepowerUP.Length; i++)
            {
                Instantiate(bullet, listepowerUP[i].transform.position, listepowerUP[i].transform.rotation);
                
            }
            Coin -= 20;
        }


        //monUI = FindObjectOfType<TextMeshProUGUI>();
        monUI.text = "Score = " + score;
        mesCoins.text = "coins = " + Coin;

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bordureJoueur")
        {
            monRigidbody.velocity = monRigidbody.velocity * (0);
        }
    }
}
