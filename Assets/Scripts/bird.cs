using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public int flapfactor = 5;
    public logic logic;
    public AudioSource flapsound;
    private bool birdisAlive = true;
    public AudioSource gameOver;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))  && birdisAlive)
        {
            rb.linearVelocity = Vector2.up * flapfactor;
            flapsound.Play();
        }

        if(transform.position.y > 5.5f || transform.position.y < -5.5f)
        {
            logic.overScreen();
            birdisAlive = false;
            gameOver.Play();    
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        logic.overScreen();
        birdisAlive = false;
        gameOver.Play();

    }
}
