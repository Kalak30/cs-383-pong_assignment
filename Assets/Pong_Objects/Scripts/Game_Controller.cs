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

    public static float diff;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Debug.Log("Game_Controller: " + Game_Controller.diff);

        scoreBoard_right.text = "0";
        scoreBoard_left.text = "0";

        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));

        activeBall = Instantiate(ball);

        Paddle paddle1 = Instantiate(paddle) as Paddle;
        Paddle paddle2 = Instantiate(paddle) as Paddle;

        paddle1.init(true); // right paddle
        paddle2.init(false); // left paddle
        
        rightPoints = 0;
        leftPoints = 0;
    }

    //After a score has been made, reset the game.
    public void reset(){
        Destroy(activeBall.gameObject);
        activeBall = Instantiate(ball);
    }


    //Methods to increase scoreboard points
    public void rightPoint(){
        rightPoints += 1;
        scoreBoard_right.text = rightPoints.ToString();
        reset();
    }

    public void leftPoint(){
        leftPoints += 1;
        scoreBoard_left.text = leftPoints.ToString();
        reset();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
