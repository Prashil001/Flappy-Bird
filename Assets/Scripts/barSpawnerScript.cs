using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float timer = 0.0f;
    public float setTimer = 2.0f;
    public float higherValue = 4.97f;
    public float lowerValue = -0.06f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<setTimer)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {

        Instantiate(Pipe, new Vector3(transform.position.x,Random.Range(lowerValue,higherValue),transform.position.z), transform.rotation);
            timer = 0;
        }
    }

}
