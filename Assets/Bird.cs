using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public float vel;
    public float jumpVel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            vel = jumpVel;
        }

        vel -= Time.deltaTime * 6f;
        transform.Translate(0, vel * Time.deltaTime, 0, Space.World);
    }

    void OnCollisionEnter(Collision other)
    {
        //Die
        Destroy(gameObject);
        Debug.Log("You died!");
    }
}
