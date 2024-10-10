using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House
{
    private string _name;
    private int _quantity;
    private int _cost;

    public House(string name, int cost)
    {
        _name = name;
        _cost = cost;
    }
    
    public int GetQuantity()
    {
        return _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetCost()
    {
        return _cost;
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
