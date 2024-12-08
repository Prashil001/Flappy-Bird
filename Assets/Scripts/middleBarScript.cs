using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleBarScript : MonoBehaviour
{
    public logic logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore(1);
    }
}
