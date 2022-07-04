using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{
   // [SerializeField] private PlanetController m_turnSpeedOrbit;
   // [SerializeField] private PlanetController m_moveSpeedOrbit;
    [SerializeField] private Transform m_rotateOrbitY ;
    [SerializeField] public Transform m_rotateOrbitX;
    [SerializeField] public float m_moveSpeed = 10f;
    [SerializeField] public float m_turnSpeed = 15f;
    // [SerializeField] private Transform m_rotateOrbitX;
    // Start is called before the first frame update
    void Awake()

    {
        //m_turnSpeedOrbit.m_turnSpeed ;
       // m_moveSpeedOrbit.m_moveSpeed ;
    }
    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(m_rotateOrbitY.up, m_rotateOrbitY.position, m_moveSpeed * Time.deltaTime);
        //transform.RotateAround(Vector3.zero, Vector3.up, 55f * Time.deltaTime);
    }
}
