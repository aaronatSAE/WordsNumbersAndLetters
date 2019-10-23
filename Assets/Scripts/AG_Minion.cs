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
        // LOOK AT TURRET
        transform.LookAt(turret.transform.position);

        // MOVE
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
