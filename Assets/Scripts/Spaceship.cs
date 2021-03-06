﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour
{
    public float speed = 5f;
    public float shotDelay = 0.05f;
    public GameObject bullet;
    public bool canShot = true;
    public GameObject explosion;
    public enum ColorType { firstColor, secondColor };


    [Header("Color Attributes")]
    public Color firstColor;
    public Color secondColor;




    public void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

    public void Shot(Transform origin)
    {
        Instantiate(bullet, origin.position, origin.rotation);
        //bullet.GetComponent<Rigidbody2D>().velocity = transform.up * -1 * speed;
    }

    public void Move(Vector2 direction)
    {
        this.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
