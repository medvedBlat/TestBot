using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera topCamera;
    public Camera thirdPersonCamera;
    private bool isTopView = false;

    void Start()
    {
        topCamera.enabled = false;
        thirdPersonCamera.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            isTopView = !isTopView;
            topCamera.enabled = isTopView;
            thirdPersonCamera.enabled = !isTopView;
        }
    }
}