using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController008 : MonoBehaviour
{

    [SerializeField] GameObject _player;
    
    [Header("Karakter Zýplama Ayarý")] [SerializeField] bool _isJumpActiveButton;

    [Header("Karakter Zýplama Kuvveti")] [Range(250, 450)] [SerializeField] float _jumpSpeed = 350f;

    MoveCompenent _moveCompenent;

    Rigidbody2D _rigidBody;

    private void Awake()
    {
        
        _moveCompenent = new MoveCompenent();

        _rigidBody = GetComponentInChildren<Rigidbody2D>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJumpActiveButton = true;
        }
    }

    private void FixedUpdate()
    {
        if (_isJumpActiveButton)
        {
            _moveCompenent.JumpAxis(_rigidBody, _jumpSpeed, true);
        }

        _isJumpActiveButton = false;

    }

}
