using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int pontuaçãojogador1;
    public int pontuaçãojogador2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aumentarpontuaçãojogador1()
    {
        pontuaçãojogador1 += 1;
    }

    public void aumentarpontuaçãojogador2()
    {
        pontuaçãojogador2 += 1;
    }
}
