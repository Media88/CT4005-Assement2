using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBorder : MonoBehaviour
{

    public BoxCollider boundBox;

    private Vector3 minBounds;
    private Vector3 maxBounds;

    void Start()
    {
        minBounds = boundBox.bounds.min;
        maxBounds = boundBox.bounds.max;
    }

    
    void Update()
    {
        
    }
}
