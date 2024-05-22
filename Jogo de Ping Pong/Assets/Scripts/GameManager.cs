using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int pontuaçãojogador1;
    public int pontuaçãojogador2;

    public AudioSource SomGol;

    public TextMeshProUGUI score;

    public GameObject painelCredito;

    public Animator TransitionAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void aumentarpontuaçãojogador1()
    {
        pontuaçãojogador1 += 1;
        AtualizarTextoPontuação();
    }

    public void aumentarpontuaçãojogador2()
    {
        pontuaçãojogador2 += 1;
        AtualizarTextoPontuação();
    }

    public void AtualizarTextoPontuação()
    {
        score.text = pontuaçãojogador1 + " X " + pontuaçãojogador2;

        SomGol.Play();
    }
    
    public void sair()
    {
        Application.Quit();
        print("Saiu");
    }

    public void abrircreditos()
    {
        painelCredito.SetActive(true);
    }

    public void fecharcreditos()
    {
        painelCredito.SetActive(false);
    }

    public void Transition(string sceneName)
    {
        StartCoroutine(LoadScene(sceneName));
    }

    IEnumerator LoadScene(string sceneName){
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(sceneName);
    }

}
