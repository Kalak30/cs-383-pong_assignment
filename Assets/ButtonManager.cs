using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    
    public void MainMenuPress(){
        SceneManager.LoadScene("Main_Menu", LoadSceneMode.Single);
    }

    public void PlayGamePress(){
        SceneManager.LoadScene("Pong_Game", LoadSceneMode.Single);
    }

    public void HelpPress(){
        SceneManager.LoadScene("Help_Screen", LoadSceneMode.Single);
    }

    public void QuitPress(){
        Application.Quit();
    }
}
