using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect; // Semakin kecil, semakin lambat geraknya (background)

    void Start()
    {
        startpos = transform.position.x;

        // Coba ambil SpriteRenderer, kalau nggak ada, error friendly~
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            length = spriteRenderer.bounds.size.x;
        }
        else
        {
            // Kalau ga ada SpriteRenderer di objek ini, gunakan default panjang 0
            length = 0f;
        }
    }

    void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        // INI DIHAPUS karena kita tidak ingin infinite scrolling di objek rumah
        // if (temp > startpos + length) startpos += length;
        // else if (temp < startpos - length) startpos -= length;
    }
}
