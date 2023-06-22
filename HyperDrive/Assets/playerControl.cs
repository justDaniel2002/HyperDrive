using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public bool isDead=false;
    public float moveSpeed;

    Rigidbody2D rbd;

    private void Awake()
    {
        rbd = gameObject.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead) return;

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
        /*else
        {
            if (rbd)
            {
                rbd.velocity = Vector2.zero;
            }
        }*/

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
        /*else
        {
            if (rbd)
            {
                rbd.velocity = Vector2.zero;
            }
        }*/
    }
}
