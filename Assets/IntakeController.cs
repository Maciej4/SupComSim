using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntakeController : MonoBehaviour {
    public GameObject cube;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.StartsWith("Cube") && cube == null)
        {
            cube = other.gameObject;
        }
    }

    private void Update()
    {
        if (cube != null)
        {
            cube.transform.position = transform.position + new Vector3(0, 0.4f, 0);
            cube.transform.rotation = transform.rotation;
            cube.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    private void FixedUpdate()
    {
        if (cube != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Rigidbody rb = cube.GetComponent<Rigidbody>();
                rb.isKinematic = false;
                cube = null;
                rb.AddForce(transform.up * 400f + transform.forward * 50f, ForceMode.Acceleration);
                rb.AddTorque(Random.insideUnitCircle.normalized * 3f); //Random spin
            }
        }
    }
}

