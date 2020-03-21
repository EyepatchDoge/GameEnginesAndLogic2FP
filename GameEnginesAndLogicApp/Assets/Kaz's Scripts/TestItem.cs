using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is a test run for items that can be purchased with in-game currency 
/// </summary>
public class TestItem : MonoBehaviour, IAbility
{
    public AudioSource celeberation;

   public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayCelebrationClip();
        }
    }

    public void PlayCelebrationClip()
    {
        
            celeberation.Play();
    }


    public void UseAbility()
    {
        PlayCelebrationClip();
    }
}


//Interfaces that all abilities must implement
public interface IAbility
{
    void UseAbility();
}
