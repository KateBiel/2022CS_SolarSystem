using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipShooter : MonoBehaviour
{
  [SerializeField] private GameObject m_laserPrefab;
  [SerializeField] private Transform m_spawn;
    [SerializeField] private float m_shootForce = 100f;
   
   // Update is called once per frame
   void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject laser = Instantiate(m_laserPrefab, m_spawn.position, m_spawn.rotation);
            laser.GetComponent<Rigidbody>().AddForce(m_spawn.forward * m_shootForce);
            Destroy(laser, 5);
        }
    }
}
