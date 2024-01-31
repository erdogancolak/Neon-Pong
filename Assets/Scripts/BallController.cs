using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    [SerializeField] private float ballSpeed;
    public GameObject goalText,pauseText;
    private Rigidbody2D rb;
    private Vector3 lastVelocity;
    public Text leftScoreText,rightScoreText;
    public static int leftScorePoint,rightScorePoint;
    private int randomNumber,randomNumber2;
    private int firstYValue,secondYValue;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        randomNumber = Random.Range(0, 2);
        randomNumber2 = Random.Range(0, 2);
        firstYValue = Random.Range(-160, -100);
        secondYValue = Random.Range(100, 200);
    }
    void Start()
    {
        if (randomNumber == 1 && randomNumber2 == 1)
        {
            rb.AddForce(new Vector2(80, firstYValue));
        }
        if (randomNumber == 1 && randomNumber2 == 0)
        {
            rb.AddForce(new Vector2(80, secondYValue));
        }
        if (randomNumber == 0 && randomNumber2 == 1)
        {
            rb.AddForce(new Vector2(-80, firstYValue));
        }
        if (randomNumber == 0 && randomNumber2 == 0)
        {
            rb.AddForce(new Vector2(-80, secondYValue));
        }
        leftScoreText.text = leftScorePoint.ToString();
        rightScoreText.text = rightScorePoint.ToString();
    }

    void Update()
    {
        lastVelocity = rb.velocity;       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            audioManager.instance.Play("hitSound");
        }
        var speed = lastVelocity.magnitude;
        var dir = Vector2.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = dir * Mathf.Max(speed, 1f);
        rb.AddForce(dir * ballSpeed);
        if(rb.velocity.x < 0.5f && rb.velocity.x > -0.5f)
        {
            StartCoroutine(pauseGame());
        }
        if (rb.velocity.y < 0.6f && rb.velocity.y > -0.6f)
        {
            StartCoroutine(pauseGame());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioManager.instance.Play("goalSound");
        if(collision.gameObject.CompareTag("rightGoal"))
        {
            leftScorePoint++;
            leftScoreText.text = leftScorePoint.ToString();
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(restartScene());
        }
        if (collision.gameObject.CompareTag("leftGoal"))
        {
            rightScorePoint++;
            rightScoreText.text = rightScorePoint.ToString();
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(restartScene());
        }
    }

    public IEnumerator restartScene()
    {        
        if(rightScorePoint == GUI.finalScoreCount)
        {
            rightScoreText.text = "WIN!";
            leftScoreText.text = "LOSE!";
            rightScorePoint = 0;
            leftScorePoint = 0;
            yield return new WaitForSeconds(4f);
            SceneManager.LoadScene(0);
        }
        else if(leftScorePoint == GUI.finalScoreCount)
        {
            leftScoreText.text = "WIN!";
            rightScoreText.text = "LOSE!";
            rightScorePoint = 0;
            leftScorePoint = 0;
            yield return new WaitForSeconds(4f);
            SceneManager.LoadScene(0);
        }
        else
        {
            goalText.SetActive(true);
            yield return new WaitForSeconds(2.5f);
            SceneManager.LoadScene(1);
        }
        
    }

    public IEnumerator pauseGame()
    {
        audioManager.instance.Play("faulSound");
        yield return new WaitForSeconds(1f);
        rb.velocity = new Vector2(0, 0);
        pauseText.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(1);
    }
}
