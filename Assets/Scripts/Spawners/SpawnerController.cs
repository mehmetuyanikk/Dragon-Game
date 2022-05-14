using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

    [SerializeField] GameObject[] _trees;

    [SerializeField] GameObject _redDragon;

    [SerializeField] UnityEngine.Transform _treeTransform, _redDragonTransform;
    
    [SerializeField] float _randomSpawnTimeTree, _randomSpawnTimeDragon, _currentTimeDragon, _currentTimeTree;

    [Range(1, 5)] [SerializeField] float _minSpawnTime;
    [Range(2, 6)] [SerializeField] float _maxSpawnTime;

    void Update()
    {
        
        
    }

    private void FixedUpdate()
    {
        _currentTimeTree += Time.deltaTime;
        _currentTimeDragon += Time.deltaTime;

        if (_currentTimeTree > _randomSpawnTimeTree)
        {
            TreeSpawnStart();
            ResetTimeTree();
        }

        if (_currentTimeDragon > _randomSpawnTimeDragon)
        {
            RedDragonSpawnStart();
            ResetTimeDragon();
        }
    }

    void TreeSpawnStart()
    {
        int _randomIndex = Random.Range(0, _trees.Length);
        Instantiate(_trees[_randomIndex], _treeTransform.position, _treeTransform.rotation, _treeTransform.transform);
        ResetTimeTree();
    }

    void RedDragonSpawnStart()
    {
   
        Instantiate(_redDragon, _redDragonTransform.transform.position, _redDragonTransform.transform.rotation, _redDragonTransform.transform);
        ResetTimeDragon();
    }

    void ResetTimeTree()
    {
        _currentTimeTree = 0;
        _randomSpawnTimeTree = Random.Range(_minSpawnTime, _maxSpawnTime);
    }

    void ResetTimeDragon()
    {
        _currentTimeDragon = 0;
        _randomSpawnTimeDragon = Random.Range(_minSpawnTime, _maxSpawnTime);
    }

}
