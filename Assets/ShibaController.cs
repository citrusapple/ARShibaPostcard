using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ShibaController : MonoBehaviour
{
    private Rigidbody rb;
    private Animation anim;
    // start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();
    }

    // update is called once per frame
    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");

        //movement script for shiba to move forward/backwards/left/right respective to postcard
        Vector3 movement = new Vector3(x, -y, 0);
        rb.velocity = movement * 10f;

        //change the below, axis is wrong buggy control  
        if (x != 0 && y != 0)
        {
            //transform.rotate(0 ,mathf.atan2(-y, x) * mathf.rad2deg, 0);
            //transform.eulerangles = new vector3(mathf.atan2(y, x) * mathf.rad2deg , transform.eulerangles.y, transform.eulerangles.z);
            //transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - transform.position, Vector3.up);

        }
        if (x != 0 || y != 0)
        {
            anim.Play("backbone|backboneaction.001");
        }
    }
}

