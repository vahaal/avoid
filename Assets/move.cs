using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float positionBorder = 4f;
    Vector3 positionX;
    float moveSpeed = 0.1f;

    private void Start()
    {
        positionX = transform.position;
    }
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * moveSpeed;

        //transform.position = Mathf.Clamp(positionX, positionBorder, positionBorder);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
