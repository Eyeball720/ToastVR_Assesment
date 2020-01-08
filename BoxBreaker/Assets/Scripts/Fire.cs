using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject ammo;
    public float force;
    public GameObject firePoint;
    GameObject jerry;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            jerry = Instantiate(ammo, firePoint.transform.position, Quaternion.identity);
        }
    }
}
