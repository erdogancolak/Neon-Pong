using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject Player1,Player2,Ball;
    public Sprite yellow, green, red, orange, blue, purple;
    public Sprite yellowBall, greenBall, redBall, orangeBall, blueBall, purpleBall;
    private int pauseIndex;
    private SpriteRenderer leftsp, rightsp, ballsp;
    public GameObject pauseText,menuButtonGO;

    private void Awake()
    {
        leftsp = Player1.GetComponent<SpriteRenderer>();
        rightsp = Player2.GetComponent<SpriteRenderer>();
        ballsp = Ball.GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        Time.timeScale = 1.0f;
        pauseIndex = 0;
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

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && pauseIndex == 0)
        {
            pauseText.SetActive(true);
            menuButtonGO.SetActive(true);
            Time.timeScale = 0f;
            pauseIndex++;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseIndex == 1)
        {
            pauseText.SetActive(false);
            menuButtonGO.SetActive(false);
            Time.timeScale = 1f;
            pauseIndex--;
        }
    }

    public void menuButton()
    {
        SceneManager.LoadScene(0);
        BallController.leftScorePoint = 0;
        BallController.rightScorePoint = 0;
    }

}
