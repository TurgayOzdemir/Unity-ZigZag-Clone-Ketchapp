using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallController : MonoBehaviour
{
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public IEnumerator SetRigidbodyValues()
    {
        yield return new WaitForSeconds(0.75f);
        _rb.isKinematic = false;
        _rb.useGravity = true;
    }
}
