
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    public float fallSpeed;

    
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * fallSpeed);
    }

    public abstract void PickMeUp();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PickMeUp();
        }
    }
}
