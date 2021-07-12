using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce;
    public float sidewaysForce;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vel = Vector3.zero;
        if (Input.GetKey("w"))
        {
            vel += transform.forward * forwardForce;
        }
        if (Input.GetKey("s"))
        {
            vel -= transform.forward * forwardForce;
        }
        if (Input.GetKey("a"))
        {
            vel -= transform.right * sidewaysForce;

        }
        if (Input.GetKey("d"))
        {
            vel += transform.right * sidewaysForce;
        }
        rb.velocity = new Vector3(vel.x, rb.velocity.y, vel.z);
       /* if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        } */
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ladder")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
