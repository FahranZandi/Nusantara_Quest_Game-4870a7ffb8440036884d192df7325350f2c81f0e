using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ChangeScene : MonoBehaviour
{
    [Header("Scene tujuan (drag scene asset ke sini)")]
    public SceneAsset targetScene; // Bisa drag and drop scene di Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
#if UNITY_EDITOR
        string sceneName = targetScene != null ? targetScene.name : null;
#else
        // Di build, kita tidak bisa akses SceneAsset, jadi hardcode atau gunakan cara lain.
        string sceneName = ""; // Buat cara alternatif di sini kalau perlu
#endif

        if (collision.CompareTag("Player"))
        {
            if (!string.IsNullOrEmpty(sceneName))
            {
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                Debug.LogWarning("Scene belum dipilih di Inspector, tidak bisa pindah scene.");
            }
        }
    }
}
