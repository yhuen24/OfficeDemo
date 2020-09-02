using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("open");
            animator.SetBool("near", true);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            Debug.Log("close");
            animator.SetBool("near", false);
        }
    }

}
