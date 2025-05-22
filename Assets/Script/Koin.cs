using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Hilangkan koin
            Destroy(gameObject);

            // (Opsional) Tambahkan skor di sini
            // ScoreManager.instance.AddScore(1);
        }
    }
}
