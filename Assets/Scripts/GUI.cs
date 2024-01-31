using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GUI : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject gameOptionsCanvas,MenuCanvas,settingsCanvas,creditSceneCanvas;
    public static int leftColor,rightColor,ballColor,finalScoreCount = 5;
    public Text leftText, ballText, rightText,finalScoreText;
    public Slider volumeSlider;
    public GameObject leftSelectedColor, rightSelectedColor, ballSelectedColor;
    public Sprite yellowSp,blueSp,redSp,greenSp,purpleSp,orangeSp;
    void Start()
    {
        leftColor = 1;
        rightColor = 4;
        ballColor = 5;
        audioSource.Play();
        finalScoreText.text = finalScoreCount.ToString();
        volumeSlider.value = .15f;
    }

    public IEnumerator creditButtonIE()
    {
        yield return new WaitForSeconds(3f);
        creditSceneCanvas.SetActive(false);
        MenuCanvas.SetActive(true);
    }

    public void creditButton()
    {
        MenuCanvas.SetActive(false);
        creditSceneCanvas.SetActive(true);
        StartCoroutine("creditButtonIE");
    }

    public void volumeChange()
    {
        audioSource.volume = volumeSlider.value;
    }
    
    public void rightArrow()
    {
        if(finalScoreCount < 5)
        {
            finalScoreCount++;
        }
        finalScoreText.text = finalScoreCount.ToString();
    }

    public void leftArrow()
    {
        if (finalScoreCount > 1)
        {
            finalScoreCount--;
        }
        finalScoreText.text = finalScoreCount.ToString();
    }

    public void settingsButton()
    {
        settingsCanvas.SetActive(true);
        MenuCanvas.SetActive(false);
    }


    public void playButton()
    {
        gameOptionsCanvas.SetActive(true);
        MenuCanvas.SetActive(false);
    }

    public void goButton()
    {
        SceneManager.LoadScene(1);
    }

    public void leftYellowButton()
    {
        leftColor= 1;
        leftSelectedColor.GetComponent<SpriteRenderer>().sprite = yellowSp;
    }
    public void leftGreenButton()
    {
        leftColor = 2;
        leftSelectedColor.GetComponent<SpriteRenderer>().sprite = greenSp;
    }
    public void leftRedButton()
    {
        leftColor = 3;
        leftSelectedColor.GetComponent<SpriteRenderer>().sprite = redSp;
    }
    public void leftOrangeButton()
    {
        leftColor = 4;
        leftSelectedColor.GetComponent<SpriteRenderer>().sprite = orangeSp;
    }
    public void leftBlueButton()
    {
        leftColor = 5;
        leftSelectedColor.GetComponent<SpriteRenderer>().sprite = blueSp;
    }
    public void leftPurpleButton()
    {
        leftColor = 6;
        leftSelectedColor.GetComponent<SpriteRenderer>().sprite = purpleSp;
    }
    public void rightYellowButton()
    {
        rightColor = 1;
        rightSelectedColor.GetComponent<SpriteRenderer>().sprite = yellowSp;
    }
    public void rightGreenButton()
    {
        rightColor = 2;
        rightSelectedColor.GetComponent<SpriteRenderer>().sprite = greenSp;
    }
    public void rightRedButton()
    {
        rightColor = 3;
        rightSelectedColor.GetComponent<SpriteRenderer>().sprite = redSp;
    }
    public void rightOrangeButton()
    {
        rightColor = 4;
        rightSelectedColor.GetComponent<SpriteRenderer>().sprite = orangeSp;
    }
    public void rightBlueButton()
    {
        rightColor = 5;
        rightSelectedColor.GetComponent<SpriteRenderer>().sprite = blueSp;
    }
    public void rightPurpleButton()
    {
        rightColor = 6;
        rightSelectedColor.GetComponent<SpriteRenderer>().sprite = purpleSp;
    }
    public void ballYellowButton()
    {
        ballColor = 1;
        ballSelectedColor.GetComponent<SpriteRenderer>().sprite = yellowSp;
    }
    public void ballGreenButton()
    {
        ballColor = 2;
        ballSelectedColor.GetComponent<SpriteRenderer>().sprite = greenSp;
    }
    public void ballRedButton()
    {
        ballColor = 3;
        ballSelectedColor.GetComponent<SpriteRenderer>().sprite = redSp;
    }
    public void ballOrangeButton()
    {
        ballColor = 4;
        ballSelectedColor.GetComponent<SpriteRenderer>().sprite = orangeSp;
    }
    public void ballBlueButton()
    {
        ballColor = 5;
        ballSelectedColor.GetComponent<SpriteRenderer>().sprite = blueSp;
    }
    public void ballPurpleButton()
    {
        ballColor = 6;
        ballSelectedColor.GetComponent<SpriteRenderer>().sprite = purpleSp;
    }
    public void exitButton()
    {
        gameOptionsCanvas.SetActive(false);
        MenuCanvas.SetActive(true);
        settingsCanvas.SetActive(false);
    }






}
