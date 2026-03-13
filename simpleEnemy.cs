using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Trascina qui il tuo Player (Empty)
    public Vector3 offset = new Vector3(0, 5, -10);
    public float smoothness = 5f;

    void LateUpdate() {
        if (target == null) return;
        
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothness * Time.deltaTime);
        transform.LookAt(target); // La camera guarda sempre il player
    }
}