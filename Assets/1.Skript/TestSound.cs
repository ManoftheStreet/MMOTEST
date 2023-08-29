using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public AudioClip   audioclip;
    public AudioClip   audioclip2;
    private void OnTriggerEnter(Collider other)
    {
        /*AudioSource audio = GetComponent<AudioSource>();
        audio.PlayOneShot(audioclip);
        audio.PlayOneShot(audioclip2);
        float lifeTime = Mathf.Max(audioclip.length, audioclip2.length);

        GameObject.Destroy(gameObject, lifeTime);*/

        Managers.Sound.Play(Define.Sound.Effect, "UnityChan/univ0001");
        Managers.Sound.Play(Define.Sound.Effect, "UnityChan/univ0002");
    }
}
