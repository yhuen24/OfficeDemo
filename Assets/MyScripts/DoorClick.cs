using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClick : MonoBehaviour
{
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out hit, 1000.0f))
            {
                Rigidbody rb;
                if (rb = hit.transform.GetComponent<Rigidbody>())
                {
                        Debug.Log("open");
                        animator.SetBool("near", true);  
                }
            }
        }
    }
}
