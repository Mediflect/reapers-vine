using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Medi;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public string gameSceneName;
    [Header("DEBUG")]

    private bool acceptingInput = true;

    private void Awake()
    {
        // App.Request(OnAppExists);
    }

    private void OnAppExists()
    {
        // StartCoroutine(RunTitleSequence());
    }

    private void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            StartCoroutine(RunExitSequence());
        }
    }

    private IEnumerator RunExitSequence()
    {
        SceneManager.LoadScene(gameSceneName);
        yield break;
    }
}