using UnityEngine;

public class MovimentoCamera : MonoBehaviour
{
    public Transform cameraTransform;
    public float velocity = 5;
    public float aux = 5;
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

        if (Aceleradores.aceleracaototal > Desaceleradores.desaceleracaototal)
        {
            rb.AddForce(direction * velocity * Aceleradores.aceleracaototal);
        }
        else if(Aceleradores.aceleracaototal < Desaceleradores.desaceleracaototal)
        {
            aux = velocity;
            velocity -= Desaceleradores.desaceleracaototal;
            rb.AddForce(direction * velocity);
        }

        if(Aceleradores.aceleracaototal == 0 || Desaceleradores.desaceleracaototal == 0)
        {
            velocity = aux;
            rb.AddForce(direction * velocity);
        }

            rb.maxAngularVelocity = 300f;
    }
}
