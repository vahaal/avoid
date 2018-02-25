using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {
    
    public float delay;
    public GameObject Cube;
    public float createRate = 1.5f, createRateTimer;
    public float rateIncrease = 0.1f, initialCreateDelay = 3.0f;
    public int callCounter = 0, callsBeforeRateIncrease = 10;

    public Rigidbody cubeRigidBody;

    void Start()
    {
        createRateTimer = createRate + initialCreateDelay;
        cubeRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        createRateTimer -= Time.deltaTime;
        if (createRateTimer <= 0)
        {
            CustomInvoke();
        }
    }

    void CustomInvoke()
    {
        Instantiate(Cube, new Vector3(Random.Range(-4,4),15,0),Random.rotation);
        callCounter++;
        if (callCounter >= callsBeforeRateIncrease)
        {
            createRate -= rateIncrease;
            callCounter = 0;
        }
        createRateTimer = createRate;
    }

}

