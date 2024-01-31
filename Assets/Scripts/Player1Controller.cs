using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
    }


    void Update()
    {
            if (Input.GetKey(KeyCode.W) && transform.position.y < 1.981f)
            {
                transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > -1.981)
            {
                transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
            }
        
    }
}
