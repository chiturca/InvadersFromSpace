using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopMovement : MonoBehaviour
{
    public float speed;
    BoxCollider2D box;
    float bgHeight;

    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        bgHeight = box.size.y;
    }


    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        
        if (transform.position.y <= -bgHeight)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 2 * bgHeight);
        }
    }
}
