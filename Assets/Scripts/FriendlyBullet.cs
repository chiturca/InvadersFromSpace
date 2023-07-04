using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyBullet : MonoBehaviour
{
    private float speed = 10;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
