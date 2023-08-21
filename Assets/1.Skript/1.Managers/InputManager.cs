using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public Action KeyAction = null; //Action ��������Ʈ
    
    public void OnUpdate()
    {
        if (Input.anyKey == false)
            return;

        if (KeyAction != null)//�Էµ� Ű�� �ִٸ�
            KeyAction.Invoke();//Invoke : ȣ��
    }
}
