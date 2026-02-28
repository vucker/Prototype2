using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 5f;
    private float downBound = -13f;

    void Update()
    {
        if (transform.position.z > topBound || transform.position.z < downBound)
        {
            Destroy(gameObject);
        }
    }
}
