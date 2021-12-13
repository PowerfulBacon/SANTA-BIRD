using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerThing : MonoBehaviour
{

    private float timer = 0.0f;

    public GameObject pipePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Time.time)
        {
            timer = Time.time + 5.0f;
            //Spawn a pipe
            Instantiate(pipePrefab, new Vector3(20, Random.Range(-5.0f, 5.0f), 0), Quaternion.identity);
        }
    }
}
