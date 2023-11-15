using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_to_game : MonoBehaviour
{

    private void Start()
    {
        
    }

    public void Button_Start()
    {
        SceneManager.LoadScene(1);
    }
    public void Button_Exit()
    {

        Application.Quit();
    }

    public void Button_Help(){
        SceneManager.LoadScene(2);
    }

    public void Button_Menu()
    {
        SceneManager.LoadScene(0);
    }
}
