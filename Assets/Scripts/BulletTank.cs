using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTank : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(-transform.forward * 800f);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
