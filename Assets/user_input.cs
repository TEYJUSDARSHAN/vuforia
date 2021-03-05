using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class user_input : MonoBehaviour
{
    public RectTransform right_half;
    public RectTransform left_half;
    float initial_scale;

    private void Start()
    {
        initial_scale = right_half.localScale.x;
    }

    public void apply_flip_filter()
    {
        right_half.localScale = new Vector3(-initial_scale, initial_scale, initial_scale);
        left_half.localScale = new Vector3(-initial_scale, initial_scale, initial_scale);
    }

    public void remove_flip_filter()
    {
        right_half.localScale = new Vector3(initial_scale, initial_scale, initial_scale);
        left_half.localScale = new Vector3(initial_scale, initial_scale, initial_scale);
    }
}
