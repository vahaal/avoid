using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyGround : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (Time.timeScale == 10)
        {
            Time.timeScale += 0.05f;
        }
        if (Time.timeScale == 20)
        {
            Time.timeScale += 0.03f;
        }
        else
            Time.timeScale += 0.1f;
    }
}
