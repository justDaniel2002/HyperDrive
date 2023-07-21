using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public bool isDead=false;
    public bool isSheid = false;
    public bool isArmed = false;
    public float moveSpeed;
    public double limitXLeft = -4;
    public double limitXright = 4;
    public double limitY = 6.04;
    public GameObject explosionVFX;

    Rigidbody2D rbd;
    Animator animator;

    private void Awake()
    {
        rbd = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead || !GameManager.Ins.isGamePlay) return;

        //set up moving
        if (GamepadController.Ins.CanMoveLeft)
        {
            if (rbd)
            {
                rbd.velocity = Vector2.left * moveSpeed;
            }
        }

        else if (GamepadController.Ins.CanMoveRight)
        {
            if (rbd)
            {
                rbd.velocity = Vector2.right * moveSpeed;
            }
        }

        if (GamepadController.Ins.CanMoveForward)
        {
            if (rbd)
            {
                rbd.velocity = Vector2.up * moveSpeed;
            }
        }

        else if (GamepadController.Ins.CanMoveBack)
        {
            if (rbd)
            {
                rbd.velocity = Vector2.down * moveSpeed;
            }
        }

        if (!GamepadController.Ins.CanMove)
        {
            if (rbd)
            {
                rbd.velocity = Vector2.zero;
            }
        }

        //set up moving limit
        if (transform.position.x <= limitXLeft)
        {
            transform.position = new Vector3((float)limitXLeft, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= limitXright)
        {
            transform.position = new Vector3((float)limitXright, transform.position.y, transform.position.z);
        }

        if (transform.position.y >= limitY)
        {
            transform.position = new Vector3(transform.position.x, (float)limitY, transform.position.z);
        }
        else if (transform.position.y <= -limitY)
        {
            transform.position = new Vector3(transform.position.x, (float)-limitY, transform.position.z);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Const.OBSTACLE_TAG))
        {
            if (isSheid)
            {
                isSheid = false;
                animator.SetBool("isSheild", isSheid);
                return;
            }
            AudioController.Ins.PlayExlodeSound();
            gameObject.SetActive(false);
            collision.gameObject.SetActive(false);

            isDead = true;

            Instantiate(explosionVFX, transform.position, Quaternion.identity);

            GameManager.Ins.GameOver();
        }

        if (collision.CompareTag(Const.ITEM_TAG))
        {
            int itemType = Random.Range(0, 1);
            if (itemType==0)
            {
                isSheid = true;
                animator.SetBool("isSheild", isSheid);
                Destroy(collision.gameObject);
            }else if (itemType == 1)
            {
                isArmed = true;
                animator.SetBool("isArmed", isArmed);
                Destroy(collision.gameObject);
            }
            
        }
    }
}
