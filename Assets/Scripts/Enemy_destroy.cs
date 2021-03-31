using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_destroy : MonoBehaviour
{
    [SerializeField] GameObject DeathFX;
    private void Start()
    {
        gameObject.AddComponent<BoxCollider>();
    }
    private void OnParticleCollision(GameObject other)
    {
        Instantiate(DeathFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
