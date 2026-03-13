using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 10f;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
        // Blocca la rotazione fisica per non far cadere l'omino
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    void FixedUpdate() {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ).normalized;

        if (movement.magnitude >= 0.1f) {
            // Applica forza per il movimento
            rb.AddForce(movement * speed);

            // Ruota l'omino verso la direzione di marcia
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}