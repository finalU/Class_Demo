using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour
{
    public float tiltSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        transform.Rotate(Input.GetAxis("Horizontal") * tiltSpeed, 0, Input.GetAxis("Vertical") * tiltSpeed);
    }
}
