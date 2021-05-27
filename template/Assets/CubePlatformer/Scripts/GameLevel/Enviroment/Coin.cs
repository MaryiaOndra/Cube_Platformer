using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubePlatformer
{
    public class Coin : MonoBehaviour
    {
        public Action<Coin> OnCoinColected;

        public AudioClip CoinClip { get; private set; }

        private void Awake()
        {
            CoinClip = GetComponent<AudioSource>().clip;
        }

        private void OnTriggerEnter(Collider other)
        {
            OnCoinColected.Invoke(this);
        }

        public void Deactivate() 
        {
            gameObject.SetActive(false);
        }
    }
}
