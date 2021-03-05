using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class user_input : MonoBehaviour
{
    public RectTransform right_half;
    public RectTransform left_half;
    float initial_scale;
    public VideoPlayer video_player;
    public bool is_paused = false;
    public TrackableEventHandler track_handler;

    private void Start()
    {
        initial_scale = right_half.localScale.x;
    }

    public void play_pause()
    {
        is_paused = !is_paused;
        if (track_handler.in_view)
        {
            if (is_paused)
            {
                video_player.Pause();
            }
            else
            {
                video_player.Play();
            }
        }
        
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
