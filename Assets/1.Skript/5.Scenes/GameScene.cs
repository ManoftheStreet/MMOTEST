using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{


    protected override void Init()
    {
        base.Init();

        SceneType = Define.Scene.Game;

        for (int i = 0; i < 5; i++)
        {
            Managers.Resource.Instantiate("UnityChan");
        }
    }

    public override void Clear()
    {
        throw new System.NotImplementedException();
    }




}
