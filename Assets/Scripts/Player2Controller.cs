using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    [SerializeField] private float speed;

    void Start()
    {
    }

    void Update()
    {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 1.981f)
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -1.981f)
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
            }
             
    }
}
