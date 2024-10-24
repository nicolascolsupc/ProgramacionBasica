using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleItems : MonoBehaviour
{
    private bool _boxOnHands;
    private Rigidbody2D _box;

    private void Update()
    {
        if (_box == null)
        {
            return;
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_box.transform.parent == null)
            {
                _box.transform.SetParent(transform);
                _box.simulated = false;
            }
            else
            {
                _box.transform.SetParent(null);
                _box.simulated = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            _boxOnHands = true;
            _box = other.GetComponent<Rigidbody2D>();
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            _boxOnHands = false;
            _box = null;
        }
    }
}
