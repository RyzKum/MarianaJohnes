using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    public PlayerMovement player;

    public float crouchHeight;
    private float normalHeight;

    public Transform headCheck;
    public float headCheckLength;
    public LayerMask groundMask;

    private float yInput;

    private void Start()
    {
        normalHeight = transform.localScale.y;
    }

    private void Update()
    {
        yInput = Input.GetKey(KeyCode.C) ? -1 : 0;

        bool isHeadHitting = HeadDetect();

        if (yInput < 0 || isHeadHitting && player.IsGrounded())
        {
            if (transform.localScale.y != crouchHeight)
                transform.localScale = new Vector3(transform.localScale.x, crouchHeight, transform.localScale.z);
        }
        else
        {
            if (transform.localScale.y != normalHeight)
                transform.localScale = new Vector3(transform.localScale.x, normalHeight, transform.localScale.z);
        }
    }

    bool HeadDetect()
    {
        bool hit = Physics2D.Raycast(headCheck.position, Vector2.up, headCheckLength, groundMask);
        return hit;
    }

    private void OnDrawGizmos()
    {
        if (headCheck == null) return;

        Vector2 from = headCheck.position;
        Vector2 to = new Vector2(headCheck.position.x, headCheck.position.y + headCheckLength);

        Gizmos.DrawLine(from, to);
    }
    
    
}
