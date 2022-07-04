using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour

{
    // Update is called once per frame
    void Update()
    {
        //Vector3.up is a vector that looks like this: (0,1,0)
        transform.Rotate(Vector3.up * Time.deltaTime*30);
    }
}
