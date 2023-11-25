using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vie : MonoBehaviour
{


    public int vie;
    public GameObject referenceplayer;
    public int scoreCoin;
    public int Coin;
    public TextMeshProUGUI monUI;
    
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
       

        if (vie <= 0)
        {
            if (gameObject.tag == "mob1")
            {
                referenceplayer.GetComponent<MovementEtTir>().score += 100;
                referenceplayer.GetComponent<MovementEtTir>().scoreCoin += 100;
            }
            if (gameObject.tag == "mob2")
            {
                referenceplayer.GetComponent<MovementEtTir>().score += 200;
                referenceplayer.GetComponent<MovementEtTir>().scoreCoin += 100;
            }
            if (gameObject.tag == "mob3")
            {
                referenceplayer.GetComponent<MovementEtTir>().score += 500;
                referenceplayer.GetComponent<MovementEtTir>().scoreCoin += 100;

            }
            if (referenceplayer.GetComponent<MovementEtTir>().scoreCoin >= 500)
            {
                referenceplayer.GetComponent<MovementEtTir>().scoreCoin -= 500;
                referenceplayer.GetComponent<MovementEtTir>().Coin += 1;
            }

            Destroy(gameObject);
            
        }
        

    }
}
