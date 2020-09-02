using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    private Animator animator;
    bool isRed = false;
    // Start is called before the first frame update

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isRed)
        {
            //change color to red
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player") && isRed)
        {
            //change back the color to default
        }
    }
}
