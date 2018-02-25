using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyGround : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Time.timeScale += 0.1f;
    }
}
