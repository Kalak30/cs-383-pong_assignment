using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public Ball ball;

    Ball activeBall;
    public Paddle paddle;

    public static Game_Controller Instance;

    public static Vector2 bottomLeft;
    public static Vector2 topRight;

    int rightPoints;
    public Text scoreBoard_right;

    int leftPoints;
    public Text scoreBoard_left;

    public Text gameOverText;

    public static float diff;
    // Start is called before the first frame update
    void Start()
    {
        //Make game over text invisible now, then show it during game end screen
        gameOverText.canvasRenderer.SetAlpha(0);

        Instance = this;


        //Score board
        scoreBoard_right.text = "0";
        scoreBoard_left.text = "0";

        rightPoints = 9;
        leftPoints = 0;


        //Game state and stuff
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));

        activeBall = Instantiate(ball);

        Paddle paddle1 = Instantiate(paddle) as Paddle;
        Paddle paddle2 = Instantiate(paddle) as Paddle;

        paddle1.init(true); // right paddle
        paddle2.init(false); // left paddle
        
        
    }

    //After a score has been made, reset the game.
    public void reset(){
        Destroy(activeBall.gameObject);
        activeBall = Instantiate(ball);
    }


    //Methods to increase scoreboard points
    public void rightPoint(){
        rightPoints += 1;
        if(rightPoints >= 10){
            endGame();
        }
        scoreBoard_right.text = rightPoints.ToString();
        reset();
    }

    public void leftPoint(){
        leftPoints += 1;
        if(leftPoints >= 10){
            endGame();
        }
        scoreBoard_left.text = leftPoints.ToString();
        reset();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    
    void endGame(){

        gameOverText.canvasRenderer.SetAlpha(255);
        StartCoroutine("Pause");
        
    }

    // Found this on unity fourm to pause game for certain amount of time with 
    // Game objects being paused
    private IEnumerator Pause(){
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(3);
        Time.timeScale = 1;
        gameOverText.canvasRenderer.SetAlpha(0);
        ButtonManager.MainMenuPress();

    }
}
