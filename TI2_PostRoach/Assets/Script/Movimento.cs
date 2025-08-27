using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Movimento : MonoBehaviour
{
    [SerializeField] private float velocidade = 4f;
    private Vector2 myInput;
    private Rigidbody rb;
    private Transform myCamera;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        myCamera = Camera.main.transform;
        rb.freezeRotation = true;
    }

    public void MoverPersonagem(InputAction.CallbackContext value)
    {
        myInput = value.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        RotacionarPersonagem();

        Vector3 forward = myCamera.TransformDirection(Vector3.forward);
        Vector3 right = myCamera.TransformDirection(Vector3.right);
        Vector3 dir = (myInput.x * right + myInput.y * forward).normalized;

        Vector3 vel = dir * velocidade;
        vel.y = dir.y * velocidade; // agora permite movimento vertical no eixo y
        rb.linearVelocity = vel;
    }

    private void RotacionarPersonagem()
    {
        Vector3 forward = myCamera.TransformDirection(Vector3.forward);
        Vector3 right = myCamera.TransformDirection(Vector3.right);
        Vector3 targetDirection = myInput.x * right + myInput.y * forward;

        if (myInput != Vector2.zero && targetDirection.magnitude > 0.1f)
        {
            Quaternion freeRotation = Quaternion.LookRotation(targetDirection.normalized);
            transform.rotation = Quaternion.Slerp(transform.rotation,
                Quaternion.Euler(new Vector3(transform.eulerAngles.x, freeRotation.eulerAngles.y, transform.eulerAngles.z)),
                10f * Time.deltaTime);
        }
    }
}