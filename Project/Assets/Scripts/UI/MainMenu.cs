﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameProject.UI
{
    public class MainMenu : Screen
    {
        [SerializeField]
        private GameObject instructionsScreen;

        [SerializeField]
        private GameObject creditsScreen;

        public void StartGame()
        {
            GameManager.Instance.LoadNewGame();
        }

        public void SetInstructionsActive(bool active)
        {
            instructionsScreen.SetActive(active);
        }

        public void SetCreditsActive(bool active)
        {
            creditsScreen.SetActive(active);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
