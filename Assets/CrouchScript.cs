using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    public float crouchHeight;
    private Vector3 normalHeight;
    private float yInput;


    private void Start()
    {
        normalHeight = transform.localScale;
    }

    private void Update()
    {
        yInput = Input.GetKey(KeyCode.C) ? -1 : 0;

        if (yInput < 0)
        {
            if(transform.localScale.y != crouchHeight)
            transform.localScale=new Vector3(normalHeight.x, crouchHeight, normalHeight.z);
        }
        else
        {
            if(transform.localScale.y != normalHeight.y)
            transform.localScale = normalHeight;

        }
    }

}
