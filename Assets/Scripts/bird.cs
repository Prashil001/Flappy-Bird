using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public AudioSource FlapSound;
    public AudioSource MainSound;
    public logic lg;
    public Rigidbody2D MyRigid;
    public float FlapSpeed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lg = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
        MainSound.Play();
    }
   public  void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="pipe" || collision.gameObject.tag=="Ground")
        {
            lg.gameOver();
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true )
        {
            MyRigid.linearVelocity = Vector2.up * FlapSpeed;
            FlapSound.Play();
        }

        if(transform.position.y>4.72)
        {
            lg.gameOver();
            Destroy(gameObject);
        }
    }
}
