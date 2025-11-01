using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5;
    void Start()
    {
        rb.linearVelocity = Vector2.left * speed;
    }

}
