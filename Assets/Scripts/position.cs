using UnityEngine;

public class position : MonoBehaviour
{
    Vector3 pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pos = transform.localPosition;
        Debug.Log("Initial Position: " + pos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
