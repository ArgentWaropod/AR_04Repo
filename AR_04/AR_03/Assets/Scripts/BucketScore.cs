using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BucketScore : MonoBehaviour
{
    public SpawnPuck manager;
    float horizontalMove = 0f;
    Rigidbody rb;
    public Joystick joystick;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        horizontalMove = joystick.Horizontal;
        rb.AddForce(new Vector3(horizontalMove * 3, 0, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        manager.score++;
        Destroy(other, 3);
    }
}
