using UnityEngine;

public class Camera_Switch : MonoBehaviour
{
    public Camera mainCamera;
    public Camera secondaryCamera;

    public Camera Bat_Cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera.enabled = true;
        secondaryCamera.enabled = false;
        Bat_Cam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            mainCamera.enabled = true;
            secondaryCamera.enabled = false;
            Bat_Cam.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            mainCamera.enabled = false;
            secondaryCamera.enabled = true;
            Bat_Cam.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            mainCamera.enabled = false;
            secondaryCamera.enabled = false;
            Bat_Cam.enabled = true;
        }
        
    }
}
