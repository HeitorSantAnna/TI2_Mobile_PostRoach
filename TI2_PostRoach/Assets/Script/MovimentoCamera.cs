using UnityEngine;

public class MovimentoCamera : MonoBehaviour
{
    public Transform cameraTransform;
    public float velocity = 5;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = cameraTransform.forward;
        //direction.y = -10;
        direction.Normalize();

        //transform.position += direction * velocity * Time.deltaTime;

        rb.AddForce(direction * velocity);

        //rb.maxAngularVelocity = 10;
    }
}
