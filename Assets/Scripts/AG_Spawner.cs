using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AG_Spawner : MonoBehaviour
{
    public GameObject minionPrefab;

    public float timer = 3f;

    // Update is called once per frame
    void Update()
    {
        // we want to spawn minions every 3 seconds

        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            timer = 3f;
            GameObject newMinion = Instantiate(minionPrefab, transform.position, transform.rotation);
        }
    }
}
