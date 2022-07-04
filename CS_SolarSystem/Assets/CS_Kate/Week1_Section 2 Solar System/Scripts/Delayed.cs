using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delayed : MonoBehaviour
{
    [SerializeField] private float m_countDown = 0.25f;
    private Rigidbody m_rb;

    private void Awake()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        m_countDown -= Time.deltaTime;
        if (m_countDown < 0f)
        {
            m_rb.isKinematic = false;
            Destroy(this);
            //this.enabled = false;  the same as  Destroy(this);
        }
    }
}