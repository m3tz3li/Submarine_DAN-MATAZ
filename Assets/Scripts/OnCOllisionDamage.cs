using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCOllisionDamage : MonoBehaviour
{
    private GameObject submarine;
    private void Start()
    {
        submarine = GameObject.Find("jarst_submarine"); // finds the submarine in the scene, not in the prefabs
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") // if collides with player, damages him
        {
            submarine.GetComponent<Submarinemovement>().Damage();
        }
    }
}
