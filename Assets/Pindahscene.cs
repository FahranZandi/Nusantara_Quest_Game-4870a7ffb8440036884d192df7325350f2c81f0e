using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Fungsi ini bisa dipanggil dari tombol
    public void GoToSceneIndex2()
    {
        SceneManager.LoadScene(2);
    }
}
