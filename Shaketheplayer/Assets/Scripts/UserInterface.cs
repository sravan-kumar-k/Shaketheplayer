﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UserInterface : MonoBehaviour
{
    public void NewGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
}
