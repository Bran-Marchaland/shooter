using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vie : MonoBehaviour
{


    public int vie;
    public int score;
    public int scoreCoin;
    public int Coin;
    // Start is called before the first frame update
    void Start()
    {
 
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "hitbox" && collision.gameObject.tag != "bordureJoueur")
        {
            vie--;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (vie == 0)
        {
            if(gameObject.tag == "mob1")
            {
                score = score + 100;
                scoreCoin = scoreCoin + 100;
            }
            if (gameObject.tag == "mob2")
            {
                score = score + 200;
                scoreCoin = scoreCoin + 100;
            }
            if (gameObject.tag == "mob3")
            {
                score = score + 500;
                scoreCoin = scoreCoin + 100;
            }

            if (scoreCoin >= 500)
            {
                scoreCoin = scoreCoin - 500;
                Coin = Coin + 1;
            }

            Destroy(gameObject);
        }


    }

}
