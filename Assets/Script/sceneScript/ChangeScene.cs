using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
#if UNITY_EDITOR
    [Header("Scene tujuan (drag scene asset ke sini)")]
    public UnityEditor.SceneAsset targetScene; // Ini hanya digunakan di Editor
    private string sceneName;

    private void OnValidate()
    {
        // Ini akan menyimpan nama scene hanya saat di Editor
        if (targetScene != null)
        {
            sceneName = targetScene.name;
        }
    }
#else
    private string sceneName = "NamaScene"; // Hardcode nama scene untuk build
#endif

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
