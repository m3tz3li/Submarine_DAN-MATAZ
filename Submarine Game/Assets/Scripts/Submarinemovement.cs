using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Submarinemovement : MonoBehaviour
{
    public Text lives;
    public Rigidbody rb;
    public float forceV = 1.5f;
    public float WSforce;
    public int Health = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // So we can reuse this
    }
    private void Update()
    {
        lives.text = Health.ToString(); // Makes the text at the top = the lives we have
        if (Input.GetKey(KeyCode.S)) // The controls S for DOWN
        {
            rb.AddForce(-transform.up * WSforce); // DOWN
        }
        if (Input.GetKey(KeyCode.W)) // The controls W for UP
        {
            rb.AddForce(transform.up * WSforce); // UP
        }
        
        if(transform.position.y > 8.5) // Keeps submarine on screen
        {
            transform.position = new Vector3(transform.position.x, 8.5f, transform.position.z);
        }
        if (transform.position.y < -7)
        {
            transform.position = new Vector3(transform.position.x, -7, transform.position.z);
        }

        if(Health <= 0) // IF no lives
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Game restarts
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * forceV, ForceMode.Acceleration); // Keeps sub going forward AND higher speeds
    }

    public void Heal()
    {
        Health = Health + 1; // Gains 1 
    }

    public void Damage()
    {
        Health = Health - 1; // Deducts 1
    }
}
