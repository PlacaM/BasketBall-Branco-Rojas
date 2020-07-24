using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public int speed = 10;
    public Rigidbody2D rb2d;



    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddForce(Vector2.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddForce(Vector2.right);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up *Time.deltaTime* speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }
    }
    
}
