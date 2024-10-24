using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    void Start()
    {
        ResetPlayerPosition();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPlayerPosition();
        }
    }

    private void ResetPlayerPosition()
    {
        _playerTransform.position = transform.position;

    }
}
