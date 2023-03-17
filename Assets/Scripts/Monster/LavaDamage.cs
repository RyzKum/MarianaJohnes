using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth PlayerHealth;
    public PlayerMovement PlayerMovement;

    private void OnParticleCollision(GameObject collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            PlayerMovement.KBCounter = PlayerMovement.KBTotalTime;
            if(collision.transform.position.x <= transform.position.x)
            {
                PlayerMovement.KnockFromRight = true;
            }
            if(collision.transform.position.x > transform.position.x)
            {
                PlayerMovement.KnockFromRight = false;
            }
            PlayerHealth.TakeDamage(damage);
        }
    }


}
