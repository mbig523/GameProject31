using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    int number = 10;
    float decimalNum = 2.5f;
    bool boolean = false;

    // Start is called before the first frame update
    private void Start()
    {

        Debug.Log("Loading...");
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {

        float xDirection = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xDirection * 5f, rb.velocity.y);

        //Detect if the key is pressed down.

        if (Input.GetKeyDown(KeyCode.Space))
        { //Detect if the key is pressed down.

            GetComponent<Rigidbody2D>().velocity = new Vector3(rb.velocity.x, 7f);

        }

    }
}
