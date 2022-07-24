using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    private GroundSpawnController groundSpawnController;
    private Rigidbody rb;

    [SerializeField] private float endYValue = -7f;
    private int _groundDirection;


    private void Awake()
    {
        groundSpawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        checkGroundVerticalPosition();
    }

    private void checkGroundVerticalPosition()
    {
        if (transform.position.y <= endYValue)
        {
            setRigidbodyValues();
            setGroundNewPosition();

        }
    }

    private void setGroundNewPosition()
    {
        _groundDirection = Random.Range(0, 2);

        if (_groundDirection == 0)
        {
            transform.position = new Vector3(groundSpawnController.LastGroundObject.transform.position.x - 1f, groundSpawnController.LastGroundObject.transform.position.y, groundSpawnController.LastGroundObject.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(groundSpawnController.LastGroundObject.transform.position.x, groundSpawnController.LastGroundObject.transform.position.y, groundSpawnController.LastGroundObject.transform.position.z + 1f);
        }

        groundSpawnController.LastGroundObject = gameObject;
    }

    private void setRigidbodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
