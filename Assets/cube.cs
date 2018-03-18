using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {
    
    public float delay;
    public GameObject Cube, timeSlower;
    public float createRate = 1.5f, createRateTimer;
    public float rateIncrease = 0.1f, initialCreateDelay = 3.0f;
    public int callCounter = 0, callsBeforeRateIncrease = 10, bonusRate;

    public Rigidbody cubeRigidBody,timeSlowerRigidBody;

    void Start()
    {
        createRateTimer = createRate + initialCreateDelay;
        cubeRigidBody = GetComponent<Rigidbody>();
        timeSlowerRigidBody = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        createRateTimer -= Time.deltaTime;
        if (createRateTimer <= 0)
        {

            CustomInvoke();
        }
    }

    void CustomInvoke()
    {
        
        if (callCounter == bonusRate)
        {
            Instantiate(timeSlower, new Vector3(Random.Range(-4, 4), 15, 0), Random.rotation);
        }
        
        Instantiate(Cube, new Vector3(Random.Range(-4, 4), 15, 0), Random.rotation);

        callCounter++;
        if (callCounter >= callsBeforeRateIncrease)
        {
            createRate -= rateIncrease;
            callCounter = 0;
            bonusRate = Random.RandomRange(0, callsBeforeRateIncrease);
        }
        createRateTimer = createRate;
    }
    public void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
    }

}

