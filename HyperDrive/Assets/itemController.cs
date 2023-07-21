using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rgb;
    // Start is called before the first frame update
    void Start()
    {
        rgb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rgb.velocity = Vector2.down * speed;
        if (gameObject.transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
