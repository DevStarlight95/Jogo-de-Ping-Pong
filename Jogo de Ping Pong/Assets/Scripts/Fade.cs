using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartingGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator PingPong() 
    {
        yield return new WaitForSeconds(10f);
    }

    public void StartingGame() 
    {
        StartCoroutine("PingPong");
    }
    
}
