using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureMovement : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            player.transform.position = Vector3.up * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            player.transform.position = Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            player.transform.position = Vector3.down * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            player.transform.position = Vector3.right * Time.deltaTime;
        }
    }
}
