using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float flyspeed;
    public Rigidbody2D rb;
    [HideInInspector]
    public bool flying;

    private void Start()
    {
        flying = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (flying)
        {
            fly();
        }
    }
    void fly()
    {
        rb.velocity = new Vector2(flyspeed * Time.fixedDeltaTime, rb.velocity.y);
    }
}