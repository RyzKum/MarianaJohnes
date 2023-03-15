using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    public float crouchHeight;
    private float normalHeight;
    private float yInput;


    private void Start()
    {
        normalHeight = transform.localScale.y;
    }

    private void Update()
    {
        yInput = Input.GetKey(KeyCode.C) ? -1 : 0;

        if (yInput < 0)
        {
            if(transform.localScale.y != crouchHeight)
            transform.localScale=new Vector3(transform.localScale.x, crouchHeight, transform.localScale.z);
        }
        else
        {
            if(transform.localScale.y != normalHeight)
            transform.localScale=new Vector3(transform.localScale.x, normalHeight, transform.localScale.z);

        }
    }
}
