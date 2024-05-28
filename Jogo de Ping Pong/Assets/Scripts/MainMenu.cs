using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GotoMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Menu() 
    { 
    yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("MainMenu");
    }

    public void GotoMenu()
    {
        StartCoroutine("Menu");
    }
}
