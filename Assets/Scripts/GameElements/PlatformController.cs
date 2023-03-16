using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{

    public Transform poseA, poseB;
    public int Speed;
    Vector2 targetPos;



    void Start()
    {
        targetPos = poseB.position;
    }


    void Update()
    {
        if(Vector2.Distance(transform.position,poseA.position)<.1f) targetPos = poseB.position;

        if(Vector2.Distance(transform.position,poseB.position)<.1f) targetPos = poseA.position;

        transform.position = Vector2.MoveTowards(transform.position,targetPos,Speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
     {
        if(collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
            
        }
    }
}
