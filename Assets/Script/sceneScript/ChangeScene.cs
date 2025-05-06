using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // Import SceneManager untuk mengelola scene

public class ChangeScene : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Ganti scene ke scene yang diinginkan
            SceneManager.LoadScene("Scene3"); // Ganti "SceneName" dengan nama scene yang ingin dimuat
        }
    }
}


