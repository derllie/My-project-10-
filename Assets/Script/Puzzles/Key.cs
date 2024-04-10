using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private GameObject objectToShow;
    private bool grabbed;
    private void Start()
    {
        objectToShow.SetActive(false);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<CharacterController>() && !grabbed)
        {
            grabbed = true;
            StartCoroutine(GrabKeyRoutine());
        }
    }

    private IEnumerator GrabKeyRoutine()
    {
        yield return new WaitForSeconds(3);
        objectToShow.SetActive(true);
        AudioManager.instance.PlaySFX("NewLevel");
        Destroy(gameObject);
    }
}
