using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Zoom : MonoBehaviour
{
    public Camera cam;
    private float camFov;
    public float zoomSpeed;

    private float mouseScrollInput;

    void Start()
    {
        camFov = cam.fieldOfView;
    }
    void Update()
    {
        mouseScrollInput = Input.GetAxis("Mouse ScrollWheel");

        camFov -= mouseScrollInput * zoomSpeed;
        camFov = Mathf.Clamp(camFov , 30 , 60);

        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView , camFov , zoomSpeed);
    }
}
