using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    [SerializeField] public GameObject rapidPow;
    [SerializeField] public Transform rapidPos;
    protected override void OnHit()
    {
        MoveSpeed *= 2;
    }

    public override void Kill()
    {
        Instantiate(rapidPow,
           rapidPos.position, transform.rotation);
        base.Kill();
    }
}
