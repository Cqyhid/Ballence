using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerController : MonoBehaviour
{
    public Rigidbody[] rollers;
    public Rigidbody plat;
    public Transform land;
    public float upSpeed = 2;
    private bool isFinish = false;

    private bool SpeedEnough
    {
        get
        {
            for (int i = 0; i < rollers.Length; i++)
            {
                if (rollers[i].angularVelocity.y > 3)
                {
                    return true;
                }
            }
            return false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (SpeedEnough && !isFinish)
        {
            isFinish = true;
            for (int i = 0; i < rollers.Length; i++)
            {
                rollers[i].gameObject.SetActive(false);
            }
            //平台上升
            plat.isKinematic = false;
            //显示隐藏道路
            land.gameObject.SetActive(true);
        }
        if (isFinish)
        {
            plat.velocity = Vector3.up * upSpeed;
            if (plat.transform.position.y > 10)
            {
                plat.gameObject.SetActive(false);
            }
        }
    }
}
