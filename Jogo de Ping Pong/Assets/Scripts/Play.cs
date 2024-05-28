using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Play;

public class Play : MonoBehaviour
{

    [SerializeField] private GameObject StartingSceneTransition;

    [SerializeField] private GameObject EndingSceneTransition;

    // Start is called before the first frame update
    void Start()
    {
        StartingSceneTransition.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Playing()
    {
        EndingSceneTransition.SetActive(true);
        yield return new WaitForSeconds(3f);
         SceneManager.LoadScene("PingPong");
    }

    public void StartGame() 
    {
        StartCoroutine("Playing");
    }

    
    }
    
