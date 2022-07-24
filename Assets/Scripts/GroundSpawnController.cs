using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject LastGroundObject;

    [SerializeField] private GameObject groundPrefab;

    private GameObject _newGroundObject;

    private int groundDirection;

    private void Start()
    {
        GenerateRandomNewGrounds();
    }

    public void GenerateRandomNewGrounds()
    {
        for (int i = 0; i < 75; i++)
        {
            createNewGround();
        }
    }

    private void createNewGround()
    {
        groundDirection = Random.Range(0, 2);

        if (groundDirection == 0)
        {
            _newGroundObject = Instantiate(groundPrefab, new Vector3(LastGroundObject.transform.position.x - 1f, LastGroundObject.transform.position.y, LastGroundObject.transform.position.z), Quaternion.identity);
        }
        else
        {
            _newGroundObject = Instantiate(groundPrefab, new Vector3(LastGroundObject.transform.position.x, LastGroundObject.transform.position.y, LastGroundObject.transform.position.z + 1f), Quaternion.identity);
        }

        LastGroundObject = _newGroundObject;
    }
}
