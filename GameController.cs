using UnityEngine;
using TMPro; // Ricorda di installare TextMeshPro nel progetto!
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton

    public int score = 0;
    public float timer = 60f;
    public TextMeshProUGUI scoreText;
    public GameObject winScreen;

    void Awake() { instance = this; }

    void Update() {
        if (timer > 0) {
            timer -= Time.deltaTime;
            UpdateUI();
        } else {
            GameOver();
        }
    }

    public void AddScore(int points) {
        score += points;
        UpdateUI();
    }

    void UpdateUI() {
        scoreText.text = "Punti: " + score + " | Tempo: " + Mathf.Ceil(timer);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void GameOver() { /* Logica fine gioco */ }
}