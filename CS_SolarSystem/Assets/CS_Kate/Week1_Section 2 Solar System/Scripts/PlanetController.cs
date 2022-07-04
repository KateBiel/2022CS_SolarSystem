using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    [SerializeField] public float m_turnSpeed = 15f;
    [SerializeField] public float m_moveSpeed = 10f;
    
    


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up*Time.deltaTime * m_turnSpeed);
        transform.RotateAround(Vector3.zero, Vector3.up, m_moveSpeed * Time.deltaTime);
    }
}
