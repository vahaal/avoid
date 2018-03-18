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
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0,0);
        }
            //transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * moveSpeed;

            //transform.position = new Vector3( Mathf.Clamp(1, -4, 4),0,0);

    }
    private void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag == "TimeSlower")
        {
            Time.timeScale -= 0.5f;
            Debug.Log("zmnienia");
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("elo");
        }
        else
            Destroy(gameObject);

    }
}
