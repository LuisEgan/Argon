using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private float levelLoadDelay = 1f;
    [SerializeField] private GameObject deatFX;


    private void OnTriggerEnter(Collider col)
    {
        DeathSequence();
        deatFX.SetActive(true);
        Invoke(nameof(ReloadScene), levelLoadDelay);
    }

    private void DeathSequence()
    {
        SendMessage("OnPlayerDeath");
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }
}
