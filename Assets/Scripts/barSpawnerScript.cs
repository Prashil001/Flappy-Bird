using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barSpawnerScript : MonoBehaviour
{
    public GameObject bars;
    public float timer = 0;
    public float spawnTime = 2f;
    public float heightOffset = 5f;
    private float lowerheight;
    private float upperheight;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
        }
        
    }
    void spawn()
    {
        lowerheight = transform.position.y - heightOffset;
        upperheight = transform.position.y + heightOffset;
        Instantiate(bars,new Vector3(transform.position.x,Random.Range(lowerheight,upperheight),transform.position.z), transform.rotation);
    }
}
