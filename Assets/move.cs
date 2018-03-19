using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float positionBorder = 4f;
    Vector3 positionX;
    float moveSpeed = 0.1f;


    private Vector3 moveDirection = Vector3.zero;
    private void Start()
    {
        positionX = transform.position;
    }
    void Update()
    {
        
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * moveSpeed;

            

    }
    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag == "TimeSlower")
        {
            Time.timeScale -= 0.5f;
            Debug.Log("zmnienia");
            Destroy(other.gameObject);
        }

        else
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
