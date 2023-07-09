using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamepadController : Singleton<GamepadController>
{
    public bool isOnMobile;
    bool _canMoveLeft = false;
    bool _canMoveRight = false;
    bool _canMoveForward = false;
    bool _canMoveBack = false;
    bool _canMove = false;

    public bool CanMoveLeft { get => _canMoveLeft; set => _canMoveLeft = value; }
    public bool CanMoveRight { get => _canMoveRight; set => _canMoveRight = value; }
    public bool CanMoveForward { get => _canMoveForward; set => _canMoveForward = value; }
    public bool CanMoveBack { get => _canMoveBack; set => _canMoveBack = value; }
    public bool CanMove { get => _canMove; set => _canMove = value; }

    private void Awake()
    {
        MakeSingleton(false);
    }

    void PCInputHandle()
    {
        if (isOnMobile) return;

        _canMoveLeft = Input.GetKey(KeyCode.LeftArrow) ? true : false;
        _canMoveRight = Input.GetKey(KeyCode.RightArrow) ? true : false;
        _canMoveForward = Input.GetKey(KeyCode.UpArrow) ? true : false;
        _canMoveBack = Input.GetKey(KeyCode.DownArrow) ? true : false;

        _canMove = !_canMoveBack && !_canMoveForward && !_canMoveLeft && !_canMoveRight ? false : true;
        /*Debug.Log("can move left: "+ _canMoveLeft);
        Debug.Log("can move right: " + _canMoveRight);*/

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        PCInputHandle();
        _canMove = !_canMoveBack && !_canMoveForward && !_canMoveLeft && !_canMoveRight ? false : true;
    }
}
