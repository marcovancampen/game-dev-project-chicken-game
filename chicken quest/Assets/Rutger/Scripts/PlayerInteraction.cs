using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private bool touchingBreakable = false;
    private Collider colliderBeingTouched;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (touchingBreakable)
            {
                colliderBeingTouched.GetComponent<Breakable>().ChangeModel();
            }
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Breakable"))
        {
            colliderBeingTouched = other;
            touchingBreakable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Breakable"))
        {
            colliderBeingTouched = null;
            touchingBreakable = false;
        }
    }
}
