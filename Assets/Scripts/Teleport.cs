using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject ball;

    private void OnCollisionEnter(Collision collision)
    {
        ball.GetComponent<Transform>().position = new Vector3(-47.153f, 15.31f, -10.713f);
    }
}
