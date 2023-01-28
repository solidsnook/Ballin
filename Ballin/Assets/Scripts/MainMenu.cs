using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public InputAction startAction;

    void OnEnable()
    {
        startAction.Enable();
        startAction.canceled += OnStart;    // wait to release button
    }

    void OnDisable()
    {
        startAction.canceled -= OnStart;
        startAction.Disable();
    }

    public void OnStart(InputAction.CallbackContext ctx)
    {

        SceneManager.LoadScene(1);

        // yield return 0;
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("The Game"));
        
    }
}
