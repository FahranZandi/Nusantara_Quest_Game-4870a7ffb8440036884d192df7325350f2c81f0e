using UnityEngine;
using UnityEngine.SceneManagement;

public class Pindahscene1 : MonoBehaviour
{
    public string namaSceneTujuan;
    private bool bolehPindah = false;

    void Update()
    {
        if (bolehPindah && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(namaSceneTujuan);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            bolehPindah = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            bolehPindah = false;
        }
    }
}
