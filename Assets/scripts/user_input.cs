using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class user_input : MonoBehaviour
{
    public RectTransform right_half;
    public RectTransform left_half;
    float initial_scale;
    public VideoPlayer video_player;
    public bool is_paused = false;
    public TrackableEventHandler track_handler;
    public Image play_pause_button;
    public Color play_color;
    public Color pause_color;
    public Text play_pause_text;
    private void Start()
    {
        initial_scale = right_half.localScale.x;
    }

    public void play_pause()
    {
        is_paused = !is_paused;
        change_button(is_paused);
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

    public void back_to_main_manu()
    {
        SceneManager.LoadScene(0);
    }

    private void change_button(bool is_paused)
    {
        if (is_paused)
        {
            play_pause_button.color = pause_color;
            play_pause_text.text = "Play";
        }
        else
        {
            play_pause_button.color = play_color;
            play_pause_text.text = "Pause";
        }
    }
}
