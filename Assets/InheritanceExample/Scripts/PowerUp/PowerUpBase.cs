using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float _duration = 5;
    [SerializeField] private GameObject _art;
    [SerializeField] private GameObject _Col;
    protected abstract void PowerUp();
    protected abstract void PowerDown();


    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            Debug.Log("Hit");
            other.gameObject.SetActive(false);
            _art.SetActive(false);
            gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
            //PowerUp();
            StartCoroutine("ActivatePower");
            Debug.Log("Dective");
            //PowerDown();

        }
       
    }
    
    private IEnumerator ActivatePower()
    {
        Debug.Log("Active");
        PowerUp();
        yield return new WaitForSeconds(5);
        PowerDown();
        Debug.Log("DeActive");
        gameObject.SetActive(false);
    }
    private void DisableArt()
    {
        _art.SetActive(false);
        _Col.SetActive(false);
    }

}
