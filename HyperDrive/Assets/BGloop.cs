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
    public float timeSpan;
    public float delay;

    private void Awake()
    {
        _ySize = road1.GetComponent<BoxCollider2D>().size.y * road1.localScale.y;

        road1.position = Vector3.zero;

        road2.position = new Vector3(road1.position.x, road1.position.y + _ySize, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStart) return;

        timeSpan += Time.deltaTime;

        if (timeSpan > delay)
        {
            speed = speed + 5;
            Const.OBSTACLE_ADD_SPEED += 2;
            timeSpan = 0;
        }

        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if(road1.position.y<= -_ySize)
        {
            road1.position = new Vector3(road2.position.x, road2.position.y + _ySize, 0f);

            Transform temp = road1;
            road1 = road2;
            road2 = temp;

            GameManager.Ins.Score++;
            GameUIManager.Ins.UpdateScoreCounting(GameManager.Ins.Score);
        }
    }
}
