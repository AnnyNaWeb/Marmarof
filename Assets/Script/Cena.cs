using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public void Saindo(){
      
        SceneManager.LoadScene("Saindo");

    }

    public void Sair(){

        Application.Quit();
    }


}
