using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    [SerializeField] AudioClip death_clip;
    [SerializeField] GameObject DeathFX;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        dead();
    }
    private void OnParticleCollision(GameObject other)
    {
        dead();
    }
    private void dead()
    {
        Instantiate(DeathFX, transform.position, Quaternion.identity);
        player_dead();
    }

    private void player_dead()
    {
        SendMessage("onplayerdeath");
        AudioSource.PlayClipAtPoint(death_clip, Camera.main.transform.position, 0.5f);
        FindObjectOfType<Scenes_management>().reload();
    }
}
