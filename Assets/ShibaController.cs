using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ShibaController : MonoBehaviour
{
    private Rigidbody rb;
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis ("Horizontal");
        float y = CrossPlatformInputManager.GetAxis ("Vertical");

        Vector3 movement = new Vector3(x, y, 0);
        rb.velocity = movement * 10f;

        if (x != 0 && y != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, Mathf.Atan2(x, y) + Mathf.Rad2Deg);
        }
        if (x != 0 || y != 0)
        {
            anim.Play("backBone|backBoneAction.001");
        }
    }
}
