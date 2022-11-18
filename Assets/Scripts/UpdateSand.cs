using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSand : MonoBehaviour
{
    public GameObject sand;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider Player)
    {
        Vector3 SandPos = new Vector3(100, 87, transform.position.z + 400);
        Instantiate(sand, SandPos, Quaternion.identity);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
