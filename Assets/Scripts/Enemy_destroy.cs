using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_destroy : MonoBehaviour
{
    [SerializeField] GameObject DeathFX;
    [SerializeField] AudioClip death_clip;
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
        AudioSource.PlayClipAtPoint(death_clip, Camera.main.transform.position, 0.4f);
        Instantiate(DeathFX, Camera.main.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
