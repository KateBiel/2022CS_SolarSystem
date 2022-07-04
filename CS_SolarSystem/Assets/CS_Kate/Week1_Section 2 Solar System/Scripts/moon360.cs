using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon360 : MonoBehaviour



{
    [SerializeField] private Transform m_moonPoint;
    [SerializeField] private float  m_moonSpeed = 10f ;
    void Awake()
    {
        
    }
    void Update()
    {
        Vector3 destination = new Vector3(0, 180, 20);
        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, destination, Time.deltaTime);
        transform.RotateAround(m_moonPoint.position, Vector3.up, m_moonSpeed * Time.deltaTime);
        
    }
   
}