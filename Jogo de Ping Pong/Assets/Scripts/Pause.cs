using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public Transform PauseMenu;

    [SerializeField] GameObject PongStarting;
    [SerializeField] GameObject PongEnding;

    // Start is called before the first frame update
    void Start()
    {
        PongStart();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseMenu.gameObject.activeSelf)
            {
                PauseMenu.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            
            else
                {
                    PauseMenu.gameObject.SetActive(true);
                    Time.timeScale = 0;
                }
        }
    }

    public void ResumeGame()
    {
         PauseMenu.gameObject.SetActive(false);
                Time.timeScale = 1;
    }

    public void Exit() 
    {
        print("Saiu");   
        Application.Quit();
    }

    IEnumerator StartingGame() 
    {
        PongStarting.SetActive(true);
    yield return new WaitForSeconds(3f);
    }

    public void PongStart() 
    {
        StartCoroutine("StartingGame");
    }

}
