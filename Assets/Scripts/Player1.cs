using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public CharacterController controller;

    public float hiz = 12f;
    public float gravity = -9.81f;

    Vector3 velocity;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * hiz * Time.deltaTime * 2);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
;
    }
}
