using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] private float m_moveSpeed = 10f;
    [SerializeField] private float m_turnSpeed = 10f;
    [SerializeField] private Rigidbody m_rb;
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked; 
        m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_rb.AddForce(transform.forward * -m_moveSpeed);

            Debug.Log("w");
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_rb.AddForce(transform.right * m_moveSpeed);
            Debug.Log("a");
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_rb.AddForce(transform.right * -m_moveSpeed);
            Debug.Log("d");
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_rb.AddForce(transform.forward * m_moveSpeed);
            Debug.Log("s");
        }

        m_rb.AddTorque(transform.right * -Input.GetAxis("Mouse Y") * m_turnSpeed);
        m_rb.AddTorque(transform.up * Input.GetAxis("Mouse X") * m_turnSpeed );

    }
}