using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanController : MonoBehaviour
{
    private Rigidbody rigid;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rigid.angularVelocity = -1 * Vector3.up * speed;
    }
}
