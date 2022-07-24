using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmitter : MonoBehaviour
{
    private BallInputController _ballInputController;

    private void Awake()
    {
        _ballInputController = GetComponent<BallInputController>();
    }

    public Vector3 GetBallDirection()
    {
        return _ballInputController.BallDirection;
    }
}
