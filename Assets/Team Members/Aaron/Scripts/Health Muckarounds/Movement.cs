using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    private Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddRelativeForce(0, 0.01f, Input.GetAxisRaw("Vertical") * speed);
        rb.AddTorque(transform.up * rotationSpeed * Input.GetAxisRaw("Horizontal"));
    }
}
