using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FixedUpdate is called at a fixed interval and is independant of frame rate. Put physics code here.
    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(0, speed);
        rb2d.AddForce(rb2d.velocity, ForceMode2D.Force);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
