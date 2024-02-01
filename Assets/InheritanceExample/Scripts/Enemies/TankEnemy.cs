using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : Crawler
{
    private void Start()
    {
        _health = _health * 2;
    }
    protected override void OnHit()
    {
        TankHit();
       
    }
    IEnumerator TankHit()
    {
        float OldMove = MoveSpeed;
        MoveSpeed = 0;
        yield return new WaitForSeconds(1);
        MoveSpeed = OldMove;
    }
    
}
