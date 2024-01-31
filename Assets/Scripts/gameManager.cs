using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject Player1,Player2,Ball;
    public Sprite yellow, green, red, orange, blue, purple;
    public Sprite yellowBall, greenBall, redBall, orangeBall, blueBall, purpleBall;
    private SpriteRenderer leftsp, rightsp, ballsp;

    private void Awake()
    {
        leftsp = Player1.GetComponent<SpriteRenderer>();
        rightsp = Player2.GetComponent<SpriteRenderer>();
        ballsp = Ball.GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        switch (GUI.leftColor)
        {
            case 1:
                leftsp.sprite = yellow;
                break;
            case 2:
                leftsp.sprite = green;
                break;
            case 3:
                leftsp.sprite = red;
                break;
            case 4:
                leftsp.sprite = orange;
                break;
            case 5:
                leftsp.sprite = blue;
                break;
            case 6:
                leftsp.sprite = purple;
                break;
        }
        switch (GUI.rightColor)
        {
            case 1:
                rightsp.sprite = yellow;
                break;
            case 2:
                rightsp.sprite = green;
                break;
            case 3:
                rightsp.sprite = red;
                break;
            case 4:
                rightsp.sprite = orange;
                break;
            case 5:
                rightsp.sprite = blue;
                break;
            case 6:
                rightsp.sprite = purple;
                break;
        }
        switch (GUI.ballColor)
        {
            case 1:
                ballsp.sprite = yellowBall;
                break;
            case 2:
                ballsp.sprite = greenBall;
                break;
            case 3:
                ballsp.sprite = redBall;
                break;
            case 4:
                ballsp.sprite = orangeBall;
                break;
            case 5:
                ballsp.sprite = blueBall;
                break;
            case 6:
                ballsp.sprite = purpleBall;
                break;
        }

    }

}
