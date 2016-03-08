using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        if (yaw < -60)
        { yaw = -60; }

        if (yaw > 60)
        { yaw = 60; }

        if (pitch > 20)
        { pitch = 20; }

        if (pitch < -60)
        { pitch = -60; }

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}

