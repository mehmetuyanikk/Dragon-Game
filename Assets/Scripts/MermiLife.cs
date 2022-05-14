using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiLife : MonoBehaviour
{
    [SerializeField] float _mermiTime;
    float _currentTime;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _mermiTime)
        {
            Destroy(this.gameObject);
            //Destroy(Collision.GameObject);
        }
    }
}
