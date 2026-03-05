using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformationofacube : MonoBehaviour
{
    // Speed of movement along the X-axis
    public float moveSpeed = 2f;

    // Speed of rotation around the Y-axis
    public float rotateSpeed = 60f;

    // Speed of scaling
    public float scaleSpeed = 0.5f;

    // Maximum scale limit
    public float maxScale = 2.0f;

    void Update()
    {
        // ---------------- TRANSLATION ----------------
        // Moves the cube continuously along the X-axis
        Vector3 movement = new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
        transform.Translate(movement);

        // ---------------- ROTATION ----------------
        // Rotates the cube continuously around the Y-axis
        Vector3 rotation = new Vector3(0f, rotateSpeed * Time.deltaTime, 0f);
        transform.Rotate(rotation);

        // ---------------- SCALING ----------------
        // Gradually increases the size of the cube over time
        if (transform.localScale.x < maxScale)
        {
            Vector3 scaling = Vector3.one * scaleSpeed * Time.deltaTime;
            transform.localScale += scaling;
        }
    }
}