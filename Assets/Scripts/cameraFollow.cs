using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject submarine;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(15, transform.position.y, submarine.transform.position.z);
    }
}
