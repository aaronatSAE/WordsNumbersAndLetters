using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This enemy will move toward the turret and dies when shot.
/// </summary>
public class AG_Minion : MonoBehaviour
{
    public GameObject turret;
    public float speed = 5;

    private void Start()
    {
        turret = GameObject.Find("Turret");
    }

    void Update()
    {
        if(turret != null)
        {
            // LOOK AT TURRET
            transform.LookAt(turret.transform.position);
        }

        // MOVE
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    // If bullet collides with minion, we want to destroy the minion AND the bullet
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.LogWarning("HIT " + collision.gameObject.name);

        // the bullet has collided with something!
        // let's check that it is a MINION
        if (collision.gameObject.CompareTag("Turret"))
        {
            Debug.LogWarning("HIT TURRET " + collision.gameObject.name);

            // we have hit a minion, so destroy it
            Destroy(collision.gameObject);
            // ...and the bullet
            Destroy(gameObject);
        }
    }
}
