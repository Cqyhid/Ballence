using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rigid;
    private Vector3 dir;
    public float force = 5f;
    public float torque = 5f;
    private bool brake;
    private int spin;

    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    private void Update()
    {
        dir = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        brake = Input.GetKey(KeyCode.Space);
        if(Input.GetKey(KeyCode.Q))
        {
            spin = 1;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            spin = -1;
        }
        else
        {
            spin = 0;
        }

    }
    void FixedUpdate()
    {
        if (!brake)
        {
            rigid.AddForce(dir * force, ForceMode.Force);
            rigid.AddTorque(Vector3.up * spin * torque);
        }
        else
        {
            rigid.velocity = Vector3.Lerp(rigid.velocity,new Vector3(0,rigid.velocity.y,0),0.2f);
        }
    }
}
