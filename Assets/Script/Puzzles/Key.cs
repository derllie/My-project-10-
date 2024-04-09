using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private GameObject objectToShow;

    private void Start()
    {
        objectToShow.SetActive(false);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            objectToShow.SetActive(true);
            Destroy(gameObject);
        }
    }
}
