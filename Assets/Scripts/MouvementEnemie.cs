using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementEnemie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hitbox;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = hitbox.transform.position;

    }
}
