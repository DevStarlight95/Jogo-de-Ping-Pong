using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float velocidadeJogador;
    public bool jogador1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jogador1 == true)
        {
            movimentojogador1();
        }

        if(jogador1 == false)
        {
            movimentojogador2();
        }
    }

    public void movimentojogador1()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidadeJogador * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadeJogador * Time.deltaTime);
        }
    }

    public void movimentojogador2()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * velocidadeJogador * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidadeJogador * Time.deltaTime);
        }
    }
}
