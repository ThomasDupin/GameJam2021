using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public Rigidbody2D rb;

    public GameObject bullet;
    public float bulletSpeed = 20f;

    public Camera cam;
    Vector2 mousePos;


    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        firePoint.rotation = Quaternion.Euler(0, 0, angle);


        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bulletClone = Instantiate(bullet, firePoint.position, firePoint.rotation);
            Rigidbody2D rbz = bulletClone.GetComponent<Rigidbody2D>();
            rbz.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
        }
    }
}
