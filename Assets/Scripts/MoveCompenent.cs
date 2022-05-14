using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCompenent : Imover008
{

    public float Jump => Input.GetAxis("Jump");

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JumpAxis(Rigidbody2D _rigidBody, float _forceSpeed, bool _jumpActive)
    {
        switch (_jumpActive)
        {
            case true:
                _rigidBody.AddForce(Vector2.up * _forceSpeed);
                break;

            default:
                _jumpActive = false;
                break;
        }
    }

}
