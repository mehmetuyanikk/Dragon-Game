using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiSpawn : MonoBehaviour
{
    [SerializeField] GameObject _mermi;
    [SerializeField] UnityEngine.Transform _mermiTransform;

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_mermi, _mermiTransform.position, _mermiTransform.rotation);
        }

    }

}