using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particules : MonoBehaviour
{
    public ParticleSystem followedObject;
    public GameObject Triangle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Triangle.transform.position = this.gameObject.transform.position;
    }
}
