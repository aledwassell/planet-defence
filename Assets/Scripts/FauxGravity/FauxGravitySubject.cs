using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravitySubject : MonoBehaviour
{
    Rigidbody2D rb;
    FauxGravityBody planetCtrl;

    void Start()
    {
        planetCtrl = GameObject.FindGameObjectWithTag("Planet").GetComponent<FauxGravityBody>();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        planetCtrl.Gravitate(transform);
    }
}
