using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = new Vector3();
        diff.x = Player.transform.position.x;
        diff.z = Player.transform.position.z;
        diff.y = gameObject.transform.position.y;
        gameObject.transform.position = diff;
    }
}
