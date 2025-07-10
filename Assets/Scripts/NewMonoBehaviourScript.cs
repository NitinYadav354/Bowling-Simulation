using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 initialVelocity = new Vector3(0f, 0f, 5f);
    public Vector3 initialPosition = new Vector3(-0.5f, 2.5f, -8f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component not found on this GameObject.");
        }
        else
        {
            Debug.Log("Rigidbody component successfully retrieved.");
        }
        rb.useGravity = false; // Disable gravity for the Rigidbody
        
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Pitch"))
        {
            Vector3 collisionPosition = other.contacts[0].point;
            Debug.Log("pitched at: " + collisionPosition);
            
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger: " + rb.position.y);
 
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (rb != null)
            {
                rb.position = initialPosition;
                rb.linearVelocity = Vector3.zero;
                rb.useGravity = false;
            }

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb != null)
            {
                rb.useGravity = true;
                rb.linearVelocity = initialVelocity;
            }

        }

        
    }
}
