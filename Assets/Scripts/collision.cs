using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    [SerializeField] GameObject DeathFX;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
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
        FindObjectOfType<Scenes_management>().reload();
    }
}
