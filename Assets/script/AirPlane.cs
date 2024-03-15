using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlane : MonoBehaviour
{
    public Rigidbody rb;
    public float enginePowerThurst, liftBooster, drag, angularDrag;

    private Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * enginePowerThurst);
        }

        Vector3 lift = Vector3.Project( rb.velocity, transform.forward);
        rb.AddForce(transform.up * lift.magnitude * liftBooster);

        rb.drag = rb.velocity.magnitude * drag;
        rb.angularDrag = rb.velocity.magnitude * angularDrag;

        rb.AddTorque(Input.GetAxis("Horizontal") * transform.forward*-1);
        rb.AddTorque(Input.GetAxis("Vertical") * transform.right);
    }
}
