using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameTeleport : MonoBehaviour
{
    [SerializeField] private GameObject canvasToShow;

    private void Start()
    {
        canvasToShow.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        canvasToShow.SetActive(true);
        AudioManager.instance.PlaySFX("Win");
    }
}
