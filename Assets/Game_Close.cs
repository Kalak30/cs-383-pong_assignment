using UnityEngine;

public class Game_Close : MonoBehaviour
{
    public void update(){
        if(Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }
}