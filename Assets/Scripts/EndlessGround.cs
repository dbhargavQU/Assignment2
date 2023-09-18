using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessGround : MonoBehaviour
{
    float speed = 2f;

    void Update()
    {
        // Move the ground to the left based on the speed
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
