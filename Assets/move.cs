using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
