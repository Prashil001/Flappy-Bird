using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barsManagement : MonoBehaviour
{
    public float pipeMove = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * pipeMove*Time.deltaTime;
        if(transform.position.x<-12.27)
        {
            Destroy(gameObject);
        }
    }

}
