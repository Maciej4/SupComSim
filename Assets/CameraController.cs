using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera m_botCamera;
    public Camera m_driverViepoint;

    void Start()
    {
        m_botCamera.enabled = true;
        m_driverViepoint.enabled = false;
    }

    void Update()
    {
        //This will toggle the enabled state of the two cameras between true and false each time
        if (Input.GetKeyUp(KeyCode.C))
        {
            m_botCamera.enabled = !m_botCamera.enabled;
            m_driverViepoint.enabled = !m_driverViepoint.enabled;
        }
    }

}

