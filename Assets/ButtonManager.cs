using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    
    public static void MainMenuPress(){
        SceneManager.LoadScene("Main_Menu", LoadSceneMode.Single);
    }

    public static void PlayGamePress(){
        SceneManager.LoadScene("Pong_Game", LoadSceneMode.Single);
    }

    public static void HelpPress(){
        SceneManager.LoadScene("Help_Screen", LoadSceneMode.Single);
    }

    public static void QuitPress(){
        Application.Quit();
    }
}
