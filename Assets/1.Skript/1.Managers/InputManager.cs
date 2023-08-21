using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public Action KeyAction = null; //Action 델리게이트
    
    public void OnUpdate()
    {
        if (Input.anyKey == false)
            return;

        if (KeyAction != null)//입력된 키가 있다면
            KeyAction.Invoke();//Invoke : 호출
    }
}
