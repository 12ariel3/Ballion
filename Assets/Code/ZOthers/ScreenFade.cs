﻿using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.ZOthers
{
    public class ScreenFade : MonoBehaviour
    {

        [SerializeField] private Image _screenFadeImage;

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}