using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float VelocidadeBola;
    public Rigidbody2D oRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
       oRigidbody2D.velocity = new Vector2(VelocidadeBola, VelocidadeBola) * Time.deltaTime; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
