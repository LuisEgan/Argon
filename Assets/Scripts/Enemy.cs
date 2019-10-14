using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject deathFX;
    
    // Start is called before the first frame update
    void Start()
    {
        AddNonTriggerBoxCollider();
    }

    private void AddNonTriggerBoxCollider()
    {
        Collider coll = gameObject.AddComponent<BoxCollider>();
        coll.isTrigger = false;
    }

    private void OnParticleCollision(GameObject bullet)
    {
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
//        fx.transform.parent = transform;
        Destroy(fx, 5);
        Destroy(gameObject);
    }
}
