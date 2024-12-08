using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMove : MonoBehaviour
{
    public int cloudSpeed = 5;
    public float deadZone = -20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * cloudSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
