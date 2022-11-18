using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject heart;
    public GameObject fish;
    public GameObject shark;
    bool canSpawn = true;
    bool canSpawnShark = true;
    public float timer = 3;
    public float SharkTimer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckIfCanSpawnShark()); // starts timer for shark
        StartCoroutine(CheckIfCanSpawn()); // starts timer
    }

    IEnumerator CheckIfCanSpawn()
    {
        canSpawn = false; // can't spawn
        yield return new WaitForSeconds(timer); // wait for the timer
        canSpawn = true; // can spawn
    }
    IEnumerator CheckIfCanSpawnShark()
    {
        canSpawnShark = false; // can't spawn
        yield return new WaitForSeconds(SharkTimer); // wait for the timer
        canSpawnShark = true; // can spawn
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn) // it checks if timer hits 0, and if it does, it spawns one singular fish
        {
            Vector3 randomSpawnPos = new Vector3(transform.position.x, Random.Range(-7, 10), transform.position.z); //Made a vector that chooses a random Y value between -7 and 10, but Z and X values are fixed
            Instantiate(fish, randomSpawnPos, Quaternion.identity); // spawns the fish in the vector position
            if (timer >= 1)
            {
                timer -= 0.03f; // substracts 3/10ms from timer
            }
            else
            {
                timer = 1;
            }
            StartCoroutine(CheckIfCanSpawn()); // restarts timer
        }
        if (canSpawnShark) // it checks if timer hits 0, and if it does, it spawns one singular fish
        {
            Vector3 randomSpawnPos = new Vector3(transform.position.x, Random.Range(-7, 10), transform.position.z); //Made a vector that chooses a random Y value between -7 and 10, but Z and X values are fixed
            Instantiate(shark, randomSpawnPos, Quaternion.identity); // spawns the shark in the vector position
            Instantiate(heart, randomSpawnPos, Quaternion.identity); // spawns the heart in the vector position
            if (SharkTimer >= 5)
            {
                SharkTimer -= 0.03f; // substracts 3/10ms from timer
            }
            else
            {
                SharkTimer = 5;
            }
            StartCoroutine(CheckIfCanSpawnShark()); // restarts timer
        }
    }
}
