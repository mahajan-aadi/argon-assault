using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class rocket_position : MonoBehaviour
{
    [Header("position")]
    [SerializeField] float speed = 15f;
    [SerializeField] float x_offset = 5.5f, y_offset = 3.5f;
    [Header("facing")]
    [SerializeField] float down_look = 5f, side_look = 5f;
    [SerializeField] float y_rot_factor = 20f, x_rot_factor = 30f;
    float x_value, y_value;
    bool is_dead = false;

    // Update is called once per frame
    void Update()
    {
        if (!is_dead)
        {
            position();
            rotation();
        }
    }

    void onplayerdeath() { is_dead = true; }
    private void rotation()
    {
        float x_rot = y_rot_factor * y_value + transform.localPosition.y* down_look;
        float y_rot = side_look * transform.localPosition.x;
        float z_rot = x_rot_factor * x_value;
        transform.localRotation = Quaternion.Euler(-x_rot, y_rot, -z_rot);
    }

    void position()
    {
        x_value = CrossPlatformInputManager.GetAxis("Horizontal");
        float x_raw = x_value * speed * Time.deltaTime;
        float x_pos = transform.localPosition.x + x_raw;
        x_pos = Mathf.Clamp(x_pos, -x_offset, x_offset);
        y_value = CrossPlatformInputManager.GetAxis("Vertical");
        float y_raw = y_value * speed * Time.deltaTime;
        float y_pos = transform.localPosition.y + y_raw;
        y_pos = Mathf.Clamp(y_pos, -y_offset, y_offset);
        transform.localPosition = new Vector3(x_pos, y_pos, transform.localPosition.z);
    }
}
