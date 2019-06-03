using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    private Transform ball;
    public Transform launchPoint;
    public float rotateSpeed = 5f;
    public float force = 1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            ball = other.transform;
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<BallMovement>().enabled = false;
            ball.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(ball != null)
        {
            this.transform.Rotate(Vector3.forward * Input.GetAxis("Vertical") * rotateSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.F))
            {
                this.GetComponent<SphereCollider>().enabled = false;
                ball.position = launchPoint.position;
                ball.gameObject.SetActive(true);
                ball.GetComponent<Rigidbody>().AddForce(force * launchPoint.forward, ForceMode.Impulse);
            }
        }

    }
}
