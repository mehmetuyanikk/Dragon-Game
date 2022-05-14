using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EnemyController : MonoBehaviour
{
    [SerializeField] float _treeSpeed;
    Rigidbody2D _rigidBody2D;

    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        TreeMove();
    }

    void TreeMove()
    {
        _rigidBody2D.velocity = Vector2.left * Time.deltaTime * _treeSpeed;
    }

}
