using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipScript : MonoBehaviour
{
    public float speed;
    public float shootForce;
    private Rigidbody2D rb2d;
    private Vector2 inputs = Vector2.zero;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputs.x = Input.GetAxis("Horizontal");
        inputs.y = Input.GetAxis("Vertical");
    }

    // FixedUpdate is called at a fixed interval and is independant of frame rate. Put physics code here.
    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + inputs * speed * Time.fixedDeltaTime);
    }
}
