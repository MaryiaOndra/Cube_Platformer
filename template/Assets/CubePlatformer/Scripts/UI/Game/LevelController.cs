using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CubePlatformer
{
    public class LevelController : MonoBehaviour
    {
        CharacterController chController;
        UIController uiController;

        private void Awake()
        {
            chController = GetComponentInChildren<CharacterController>();
            uiController = GetComponentInChildren<UIController>();
        }

        private void OnEnable()
        {
            uiController.OnDraggedSlider += ChangeState;
            uiController.SliderValue += ChangePlatformAngle;
        }
        private void OnDisable()
        {
            uiController.OnDraggedSlider -= ChangeState;
            uiController.SliderValue -= ChangePlatformAngle;
        }

        public void ChangeState(bool _state)
        {
            bool _plContrState = _state == true ? false : true;
            chController.enabled = _plContrState;
        }

        public void ChangePlatformAngle(float _sliderValue)
        {
            transform.rotation = Quaternion.Euler(0, _sliderValue * 360, 0);
        }
    }
}
