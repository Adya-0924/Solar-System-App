using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    // this variable is used for attaching the GameObject
    public GameObject PlanetObject;
    public Vector3 RotationVector;

    // Update is called once per frame
    void Update()
    {
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime); 
    }
}
