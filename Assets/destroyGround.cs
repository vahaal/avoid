using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyGround : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(Time.timeScale);
        Destroy(other.gameObject);
        if (Time.timeScale == 2)
        {
            Time.timeScale += 0.05f;
        }
        if (Time.timeScale == 5)
        {
            Time.timeScale += 0.03f;
        }
        else
            Time.timeScale += 0.09f;
    }
}
