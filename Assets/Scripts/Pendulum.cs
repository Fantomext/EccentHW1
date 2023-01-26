using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    float speedRotate = 10f;
    float startPos;
    float offsetMaxPosition = 0.15f;
    private void Start()
    {
        startPos = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (startPos + transform.rotation.z > offsetMaxPosition || startPos + transform.rotation.z < -offsetMaxPosition)
        {
            speedRotate = -speedRotate;
        }

        transform.Rotate(0f, 0f, 3f * speedRotate * Time.deltaTime);
    }
}
