using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;

    // praca kamery, sledzenie gracza, lateupdate zeby wszystko sie najpierw updatowalo a potem sama kamera
    void LateUpdate()
    {

        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);

    }
}
