using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public GameObject explosionVFX;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Ins.isGamePlay) return;

        rb.velocity = Vector2.up * speed;
        if(transform.position.y > 9)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Const.OBSTACLE_TAG))
        {
            Instantiate(explosionVFX, transform.position, Quaternion.identity);
            AudioController.Ins.PlayExlodeSound();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
