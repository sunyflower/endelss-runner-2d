using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //graj (ładowanie następnej sceny)
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    //wyjście z gry
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }


    //wybranie levelu 1
    public void SelectLevel1()
    {
        SceneManager.LoadScene("Game");
    }

    //wybranie levelu 2
    public void SelectLevel2()
    {
        SceneManager.LoadScene("Game2");
    }


}
