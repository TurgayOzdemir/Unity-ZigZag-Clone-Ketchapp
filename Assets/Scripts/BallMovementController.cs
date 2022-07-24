using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    private BallDataTransmitter _ballDataTransmitter;

    [SerializeField] protected float ballSpeed;

    private void Awake()
    {
        _ballDataTransmitter = GetComponent<BallDataTransmitter>();
    }

    private void Update()
    {
        setBallMovement();
    }

    private void setBallMovement()
    {
        transform.position += _ballDataTransmitter.GetBallDirection() * ballSpeed * Time.deltaTime;
    }
}
