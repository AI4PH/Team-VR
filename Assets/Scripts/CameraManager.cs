using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform Player;
    public Camera FirstPersonCam, ThirdPersonCam;
    public KeyCode TKey;
    public bool camSwitch = false;

    void fixedUpdate()
    {
        if (Input.GetKeyDown(TKey))
        {
            SwitchCamera();
        }
    }

    public void SwitchCamera()
    {
        camSwitch = !camSwitch;
        FirstPersonCam.gameObject.SetActive(camSwitch);
        ThirdPersonCam.gameObject.SetActive(!camSwitch);
    }
}
