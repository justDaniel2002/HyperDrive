using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomLimit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(Const.OBSTACLE_TAG))
        {
            Destroy(collision.gameObject);
        }
    }
}
