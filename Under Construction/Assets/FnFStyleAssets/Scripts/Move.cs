using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
    }   
}
