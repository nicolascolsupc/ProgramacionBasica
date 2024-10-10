using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace POO
{
    public class Resource
    {
        private string _name;
        private int _quantity;

        public Resource(string name)
        {
            _name = name;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public void Add(int amount)
        {
            if (amount <= 0)
            {
                Debug.LogWarning("You are trying to add negative resource, probably you need to call Remove()");
                return;
            }

            _quantity += amount; //  _quantity = quantity + amount;
        }

        public void Remove(int amount)
        {
            if (amount <= 0)
            {
                Debug.LogWarning(
                    "You are trying to remove negative resource, probably you need to call Add() if you want to add more");
                return;
            }

            _quantity -= amount;
        }
    }
}