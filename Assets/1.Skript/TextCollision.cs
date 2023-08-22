using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TextCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @{collision.gameObject.name}!");
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trriger @{other.gameObject.name}!");
    }



    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//
        {
            Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );

            Debug.DrawRay(Camera.main.transform.position,ray.direction *100f, Color.red, 1.0f);

            LayerMask mask = LayerMask.GetMask("Monster") | LayerMask.GetMask("Wall");

            //int mask = (1 << 8 | 1 << 9);
           
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f, mask))
            {
                Debug.Log($"RaycastCamera @{hit.collider.gameObject.name}");
            }
        }

       /* if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            Vector3 dir = mousePos - Camera.main.transform.position;
            dir = dir.normalized;

            Debug.DrawRay(Camera.main.transform.position, dir * 100f, Color.red, 1.0f);

            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100f))
            {
                Debug.Log($"RaycastCamera @{hit.collider.gameObject.name}");
            }
        }*/
    }
}
