using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILoader<Key,Value>
{
    Dictionary<Key, Value> WakeDict();
}

public class DataManager
{
    public Dictionary<int, Data.Stat> StatDict { get; private set; } = new Dictionary<int, Data.Stat>();

    public void Init()
    {
        StatDict = LoadJson<Data.StatData,int,Data.Stat>("StatData").WakeDict();
    }

    Loader LoadJson<Loader,Key,Value>(string path) where Loader : ILoader<Key, Value>
    {
        TextAsset textAsset = Managers.Resource.Load<TextAsset>($"4.Data/{path}");
        return JsonUtility.FromJson<Loader>(textAsset.text);
    }
}
