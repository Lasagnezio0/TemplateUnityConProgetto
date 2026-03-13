using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int pointsValue = 1;

    void OnTriggerEnter(Collider other) {
        // Controlla se l'oggetto che entra ha il tag "Player"
        if (other.CompareTag("Player")) {
            GameManager.instance.AddScore(pointsValue);
            Destroy(gameObject); // L'oggetto sparisce
        }
    }
}