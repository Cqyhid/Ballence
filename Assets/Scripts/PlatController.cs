using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatController : MonoBehaviour
{
    private Transform trans;
    private Rigidbody rigid;
    public float speed = 1f;
    private int dir = 1;
    // Start is called before the first frame update
    void Start()
    {
        trans = this.transform;
        rigid = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trans.position.y <= 2 && dir == -1)
        {
            dir = 1;
        }
        else if (trans.position.y >= 7 && dir == 1)
        {
            dir = -1;
        }
    }

    private void FixedUpdate()
    {
        rigid.MovePosition(trans.position + trans.up * dir * Time.fixedDeltaTime * speed);
    }
}
