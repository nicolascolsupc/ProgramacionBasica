using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace POO
{
    public class HouseBuilder
    {
        public void Build(House house, Resource resource)
        {
            if (resource.GetQuantity() < house.GetCost())
            {
                Debug.LogError($"Player has not enough {resource.GetName()} to build a {house.GetName()}");
                return;
            }

            resource.Remove(house.GetCost());
            Debug.Log($"Congratulation, you build a {house.GetName()}. Current {house.GetName()}: {house.GetQuantity()}");

            house.Add(1);
        }
    }
}