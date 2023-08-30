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
    PoolManager _pool = new PoolManager();
    ResourceManager _resource = new ResourceManager();
    SceneManagerEX _scene = new SceneManagerEX();
    SoundManager _sound = new SoundManager();
    UIManager _ui = new UIManager();

    public static InputManager Input { get { return Instance._input; } }
    public static PoolManager Pool { get { return Instance._pool; } }
    public static ResourceManager Resource { get { return Instance._resource; } }
    public static SceneManagerEX Scene { get { return Instance._scene; } }
    public static SoundManager Sound { get { return Instance._sound; } }
    public static UIManager UI { get { return Instance._ui; } }

    void Start()
    {
        Init();
    }

    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()//�Ŵ��� �ʱ�ȭ
    {
        if(s_instance == null)//�ν��Ͻ��� �������� ������
        {
            GameObject go = GameObject.Find("@Managers"); //���̶�Űâ���� �Ŵ����� ã��
            if(go == null)//�� ã����
            {
                go = new GameObject { name = "@Managers" }; // �Ŵ��� ������Ʈ�� �����
                go.AddComponent<Managers>();//�Ŵ��� ��ũ��Ʈ�� �߰���
            }

            DontDestroyOnLoad(go);//���� �ٲ� �ı����� �ʰ�
            s_instance = go.GetComponent<Managers>();//�ν��ӽ��� �Ŵ��� ����

            s_instance._pool.Init();
            s_instance._sound.Init();
        }

    }

    public static void Clear()
    {
        Input.Clear();
        Sound.Clear();
        Scene.Clear();
        UI.Clear();


        Pool.Clear();
    }
}
