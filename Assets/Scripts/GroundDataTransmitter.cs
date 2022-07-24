using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    private GroundFallController groundFallController;

    public void setGroundRigidbodyValues()
    {
        StartCoroutine(groundFallController.SetRigidbodyValues());
    }

    private void Awake()
    {
        groundFallController = GetComponent<GroundFallController>();
    }
}
