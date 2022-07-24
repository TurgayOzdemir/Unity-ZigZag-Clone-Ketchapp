using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    private GroundDataTransmitter groundDataTransmitter;

    private void Awake()
    {
        groundDataTransmitter = GetComponent<GroundDataTransmitter>();
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            groundDataTransmitter.setGroundRigidbodyValues();
        }
    }
}
