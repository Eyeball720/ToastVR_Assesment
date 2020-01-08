using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject ammo;
    public float force;
    public GameObject firePoint;
    GameObject jerry;
    public bool canFire = false;
    public GameObject text;
    public GameObject cannon;
    public AudioClip shot;
    AudioSource sound;

    private void Start()
    {
        sound = cannon.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canFire)
        {
            jerry = Instantiate(ammo, firePoint.transform.position, Quaternion.identity);
            sound.PlayOneShot(shot, 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canFire = true;
        text.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        canFire = false;
        text.SetActive(false);

    }
}
