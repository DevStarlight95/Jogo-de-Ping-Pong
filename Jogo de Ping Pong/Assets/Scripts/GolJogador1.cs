using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolJogador1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Bolinha"))
        {
            FindObjectOfType<GameManager>().aumentarpontuaçãojogador2();

            other.gameObject.transform.position = Vector2.zero;
        }
    }
}
