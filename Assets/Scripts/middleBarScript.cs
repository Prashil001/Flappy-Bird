using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleBarScript : MonoBehaviour
{
    public logic lg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lg = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        lg.addscore();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
