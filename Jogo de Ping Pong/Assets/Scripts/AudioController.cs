using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioSource MusicaFundo;

    // Start is called before the first frame update
    void Start()
{
    StartCoroutine(waiter());
}

IEnumerator waiter()
{

    MusicaFundo.Play();
    yield return new WaitForSecondsRealtime(4);
    
}

    
}
