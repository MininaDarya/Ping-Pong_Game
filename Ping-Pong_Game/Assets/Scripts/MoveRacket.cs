using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float speed = 30;
    public string axis = "Vertical";
    private Rigidbody2D _rigidbody2d = null;

    private void Start()
    {
        Debug.Log("Start");
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);
        _rigidbody2d.velocity = new Vector2(0, v) * speed;
    }
}