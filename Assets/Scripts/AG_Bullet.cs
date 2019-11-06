using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AG_Bullet : MonoBehaviour
{
    // If bullet collides with minion, we want to destroy the minion AND the bullet
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.LogWarning("HIT " + collision.gameObject.name);

        // the bullet has collided with something!
        // let's check that it is a MINION
        if (collision.gameObject.CompareTag("Minion"))
        {
            Debug.LogWarning("HIT MINION "+collision.gameObject.name);

            // we have hit a minion, so destroy it
            Destroy(collision.gameObject);
            // ...and the bullet
            Destroy(gameObject);
        }
    }
}
