using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControllerV1 : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public bool isFaceFront;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb != null)
        {
            if(isFaceFront)  rb.velocity = Vector2.down * speed;

            else if(!isFaceFront) rb.velocity = Vector2.up * speed;
        }
    }
}
