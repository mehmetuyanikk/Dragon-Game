using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EnemyMoverCompenent : MonoBehaviour
{

    [SerializeField] DirectionsEnums _directionEnums;
    Rigidbody2D _rigidBody;
    [SerializeField] float _dusmanHareketHizi;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = DirectionSelect() * Time.deltaTime * _dusmanHareketHizi;
    }

    Vector2 DirectionSelect()
    {
        Vector2 _directionVector2;

        if (_directionEnums == DirectionsEnums.Left)
        {
            _directionVector2 = Vector2.left;
        }

        else
        {
            _directionVector2 = Vector2.right;
        }

        return _directionVector2;
    }

    /*
    
    By yapi yazilim dilinde enum, enumaration ya da enum sabitleri olarak adlandirilir. Degiskenlerin alabilecegi degerlerin belli (sabit) oldugu durumlarda programi daha okunabilir hale gteirmek icin kullanilir.
    Prograamda bircok degiskene sayisal deger vermek yerine enum kullanilebilir. Ozet olrak enum yapisi sayilar ianlamli sekilde isimlerndirerek kullanabilmeye izin verir.

     */





}
