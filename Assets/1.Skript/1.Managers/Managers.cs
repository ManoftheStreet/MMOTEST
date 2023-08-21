using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class Managers : MonoBehaviour
{

    static Managers s_instance;
    static Managers Instance { get { Init();  return s_instance; } }

    InputManager _input = new InputManager(); 
    ResourceManager _resource = new ResourceManager();

    public static InputManager input { get { return Instance._input; } }
    public static ResourceManager Resource { get { return Instance._resource; } }




    void Start()
    {
        Init();
    }

    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()//매니저 초기화
    {
        if(s_instance == null)//인스턴스가 존재하지 않으면
        {
            GameObject go = GameObject.Find("@Managers"); //하이라키창에서 매니저를 찾음
            if(go == null)//못 찾으면
            {
                go = new GameObject { name = "@Managers" }; // 매니저 오브젝트를 만들고
                go.AddComponent<Managers>();//매니저 스크립트를 추가함
            }

            DontDestroyOnLoad(go);//씬이 바뀌어도 파괴하지 않고
            s_instance = go.GetComponent<Managers>();//인스텁스는 매니저 대입
        }

    }
}
