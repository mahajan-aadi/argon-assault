using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_destroy : MonoBehaviour
{
    [SerializeField] GameObject DeathFX;
    [SerializeField] int hit_points = 3, score = 100;
    private void Start()
    {
        gameObject.AddComponent<BoxCollider>();
    }
    private void OnParticleCollision(GameObject other)
    {
        hit_points--;
        if (hit_points < 1) { dead(); }
    }

    private void dead()
    {
        FindObjectOfType<Score_management>().increase_score(score);
        Instantiate(DeathFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
