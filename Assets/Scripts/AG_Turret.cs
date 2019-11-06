using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotates toward mouse position and shoots when you click.
/// </summary>
public class AG_Turret : MonoBehaviour
{
    public GameObject firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        #region Week6Code
        // ROTATE TO MOUSE POSITION
        // The information of what our raycast has hit.
        RaycastHit hit;
        // Create a raycast to point at the mouse's position.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        // If our raycast hits an object...
        if(Physics.Raycast(ray, out hit, 100))
        {
            //transform.LookAt(hit.transform.position);
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
        #endregion

        // SHOOT WHEN MOUSE BUTTON IS CLICKED
        // Check mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Spawn bullet
            GameObject newBullet = Instantiate(bulletPrefab, firePoint.transform.position, transform.rotation);

            // Make bullet move
            // bullet.rigidbody.AddForce(direction);
            newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 2000f);
        }

    }
}
