using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleController : MonoBehaviour
{
    public Transform UI;
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        UI.gameObject.SetActive(true);
    }
}
