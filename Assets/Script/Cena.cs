using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena : MonoBehaviour
{

   public void Jogar()
    {
        SceneManager.LoadScene("InGame");
    }
     public void Opcoes()
    {

        SceneManager.LoadScene("Options");
    }
     public void Voltar()
    {

        SceneManager.LoadScene("MainMenu");
    }

    public void Sair(){
        Application.Quit();
    }


}
