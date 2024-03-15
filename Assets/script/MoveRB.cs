using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    private float speed = -300f;
    private float rotationspeed = 100f;

    private Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        Rb.velocity = (transform.forward * vAxis) * speed * Time.deltaTime;
        transform.Rotate((transform.up * hAxis) * rotationspeed * Time.deltaTime);
    }
}
