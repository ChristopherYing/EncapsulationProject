using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int DmgAmount = 1;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject hitObject = collision.gameObject;
        TryDamageObject(hitObject);
    }
    void TryDamageObject(GameObject objectToDamage)
    {
        if (objectToDamage.TryGetComponent(out Damageable damageableObject))
        {
            damageableObject.DealDamage(DmgAmount);
        }
    }
}