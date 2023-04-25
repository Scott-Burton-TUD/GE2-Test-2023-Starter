using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPod : MonoBehaviour
{
    public Transform player;
    public Transform target;
    public GameObject pod;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Vector3 relativePos = target.position - transform.position;


            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = rotation;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.name);

        if (collision.collider.name == "pod")
        {
            player.transform.position = pod.transform.position;
        }
    }
}
