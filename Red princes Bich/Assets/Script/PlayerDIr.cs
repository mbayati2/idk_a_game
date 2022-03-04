using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDIr : MonoBehaviour
{
    
    float Dir;
    private Transform Transform;

    // Start is called before the first frame update
    void Start()
    {
        Transform = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Dir = Input.GetAxis("Horizontal");
        if (Dir > 0)
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if (Dir < 0)
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
