using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraness : MonoBehaviour
{
    public GameObject cameraHolder;
    public void SetCameraRotation(Vector3 cameraRotation)
    {
        cameraHolder.transform.localEulerAngles = cameraRotation;
    }
}
