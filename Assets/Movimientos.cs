using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int Speed = 5;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - Speed, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + Speed, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + Speed, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - Speed, transform.position.z);
        }
    }
}
