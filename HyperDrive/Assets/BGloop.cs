using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgloop : MonoBehaviour
{
    public float speed;
    public Transform road1;
    public Transform road2;
    float _ySize;
    public bool isStart;

    private void Awake()
    {
        _ySize = road1.GetComponent<BoxCollider2D>().size.y * road1.transform.localScale.y;

        road1.transform.position = Vector3.zero;

        road2.transform.position = new Vector3(road1.transform.position.x, road1.transform.position.y + _ySize, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
