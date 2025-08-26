using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    private TrailRenderer trail;
    public Vector3 initialVelocity = new Vector3(0f, 0f, 5f);
    public Vector3 initialAngularVelocity = new Vector3(0f, 0f, 0f);
    public Vector3 initialPosition = new Vector3(-0.5f, 2.5f, -8f);
    public float SwingForce = 1f;
    float releaseTime;
    float reachTime;
    float pitchEnter;
    float pitchExit;
    public float spin = 5f;
    float initialDrag;
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
        initialDrag = rb.linearDamping; // Store the initial drag value
        trail = GetComponent<TrailRenderer>();
        trail.enabled = false;


    }


    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Pitch"))
        {
            Debug.Log("velocity: " + rb.linearVelocity + ", " + (rb.linearVelocity.magnitude * 3.6));
            rb.AddForce(Vector3.right * spin);
            pitchEnter = Time.time;
            Vector3 collisionPosition = other.contacts[0].point;

            Debug.Log("pitched at: " + (10.06f - collisionPosition.z));


        }
        if (other.gameObject.CompareTag("Keeper"))
        {
            Debug.Log("velocity: " + rb.linearVelocity + ", " + (rb.linearVelocity.magnitude * 3.6));
            Debug.Log("Keeper hit:" + (other.contacts[0].point.y));

        }

    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Pitch"))
        {
            Debug.Log("Exited Pitch:" + rb.linearVelocity + ", " + (rb.linearVelocity.magnitude * 3.6f));
            rb.linearDamping = initialDrag; // Reset the drag to its initial value
            pitchExit = Time.time;

            Debug.Log("Time on pitch: "+ (pitchExit - pitchEnter));

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Batsman: y=" + (rb.position.y - 0.5f));
        Debug.Log("Velocity: " + rb.linearVelocity + ", " + (rb.linearVelocity.magnitude * 3.6f));
        reachTime = Time.time;
        Debug.Log("Time to reach: " + (reachTime - releaseTime) + " s");

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Stumps: y=" + (rb.position.y - 0.5f));
        Debug.Log("Velocity: " + rb.linearVelocity + ", " + (rb.linearVelocity.magnitude * 3.6f));

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
                rb.angularVelocity = initialAngularVelocity;
                rb.rotation = Quaternion.Euler(0f, -90f, 0f);
                rb.useGravity = false;
                trail.enabled = false;
                

            }

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb != null)
            {
                rb.useGravity = true;
                rb.linearVelocity = initialVelocity;
                Debug.Log("Velocity_i " + (rb.linearVelocity.magnitude) * 3.6f);
                releaseTime = Time.time;
                rb.angularVelocity = new Vector3(0f, 0f, 1f);
                trail.Clear();
                trail.enabled = true;

            }
        }

        if (rb.linearVelocity.z > 30f)
        {
            rb.AddForce(Vector3.right * (30f / (rb.linearVelocity.z * rb.linearVelocity.z)) * SwingForce * 0.1f);

        }

        else if (rb.linearVelocity.z < 30f)
        {
            rb.AddForce(Vector3.right * (rb.linearVelocity.z / 30f) * SwingForce * 0.1f);

        }
    }
}
