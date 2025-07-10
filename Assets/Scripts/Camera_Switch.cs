using UnityEngine;

public class Camera_Switch : MonoBehaviour
{
    public Camera mainCamera;
    public Camera secondaryCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera.enabled = true;
        secondaryCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCamera.enabled = !mainCamera.enabled;
            secondaryCamera.enabled = !secondaryCamera.enabled;
        }
        
    }
}
