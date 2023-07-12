using UnityEngine;

public class FriendlyBullet : MonoBehaviour
{
    private float speed = 10;

    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Alien"))
        {
            collision.gameObject.GetComponent<Alien>().Kill();
            gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
