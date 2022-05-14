using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    
    [SerializeField] Rigidbody2D _rigidBody;
    [SerializeField] float _mermiHiz;

    private void FixedUpdate()
    {
        mermi();
    }

    void mermi()
    {
        _rigidBody.velocity = Vector2.right * _mermiHiz;
    }

}
