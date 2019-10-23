using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotates toward mouse position and shoots when you click.
/// </summary>
public class AG_Turret : MonoBehaviour
{
    void Update()
    {
        // ROTATE TO MOUSE POSITION
        // The information of what our raycast has hit.
        RaycastHit hit;
        // Create a raycast to point at the mouse's position.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        // If our raycast hits an object...
        if(Physics.Raycast(ray, out hit, 100))
        {
            //transform.LookAt(hit.transform.position);
            transform.LookAt(new Vector3(hit.point.x, 0, hit.point.z));
        }

        // SHOOT WHEN MOUSE BUTTON IS CLICKED

    }
}
