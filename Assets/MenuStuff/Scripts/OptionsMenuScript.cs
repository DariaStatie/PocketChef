﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenuScript : MonoBehaviour
{
    public void goBack() {
        SceneManager.LoadScene("MainMenu");
    }
}
