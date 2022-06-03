using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] int speed = 10;

    public Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float depth = Input.GetAxis("Vertical");
        float vertical = rb.velocity.y;

        if (Input.GetKey("space"))
        {
            vertical = speed / 2;
        }

        rb.velocity = new Vector3(horizontal * speed, vertical, depth * speed);
    }

}
