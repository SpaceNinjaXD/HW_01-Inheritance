using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerUp : PowerUpBase
{
    private TurretController turCon;
    private float tempFire;
    private void Start()
    {
       turCon = GameObject.Find("TurretController").GetComponent<TurretController>();
        tempFire = turCon.FireCooldown;
        Debug.Log(turCon.FireCooldown + "CurrentFireSpeed");
    }
    protected override void PowerDown()
    {
        turCon.FireCooldown = tempFire;
        Debug.Log(turCon.FireCooldown + "CurrentFireSpeed");
    }

    protected override void PowerUp()
    {
        turCon.FireCooldown = .1f;
        Debug.Log(turCon.FireCooldown + "CurrentFireSpeed");
    }

}
