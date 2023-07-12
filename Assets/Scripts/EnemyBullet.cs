using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private float speed = 10;
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
