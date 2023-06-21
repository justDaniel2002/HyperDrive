using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamepadController : Singleton<GamepadController>
{
    public bool isOnMobile;
    bool _canMoveLeft = false;
    bool _canMoveRight = false;

    public bool CanMoveLeft { get => _canMoveLeft; set => _canMoveLeft = value; }
    public bool CanMoveRight { get => _canMoveRight; set => _canMoveRight = value; }

    private void Awake()
    {
        MakeSingleton(false);
    }

    void PCInputHandle()
    {
        if (isOnMobile) return;

        _canMoveLeft = Input.GetKey(KeyCode.LeftArrow) ? true : false;
        _canMoveRight = Input.GetKey(KeyCode.RightArrow) ? true : false;
        Debug.Log("can move left: "+ _canMoveLeft);
        Debug.Log("can move right: " + _canMoveRight);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PCInputHandle();
    }
}
