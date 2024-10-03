using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{

    private int _currentWoods;
    private int _currentStones;
    private int _currentMoney;
    private int _woodHouses;
    private int _stoneHouses;
    private int _mixedHouses;
    private List<string> _registryList = new List<string>();

    public int initMoney = 100;
    public int woodCost = 10; 
    public int stoneCost = 15;
    public int stoneLimit = 20;
    public int woodLimit = 20;
    public int earnMoney = 20;
    public int woodHouseCost = 5;
    public int stoneHouseCost = 5;
    public int mixedHouseStoneCost = 5;
    public int mixedHouseWoodCost = 5;

    private void Start()
    {
        _currentMoney = initMoney;
    }

    void Update()
    {
        CheckInputs();
    }

    private void CheckInputs()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            BuyWood();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            BuyStone();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            EarnMoney();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            BuildWoodHouse();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            BuildStoneHouse();
        }
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            BuildMixedHouse();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ShowResources();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            ShowRegister();
        }
    }
    
    private void BuyWood()
    {
        if (_currentMoney >= woodCost)
        {
            if (_currentWoods < woodLimit)
            {
                _currentMoney -= woodCost;
                _currentWoods++;
                Debug.Log($"You buy wood. current wood: {_currentWoods}");
                RegisterData();
            }
            else
            {
                Debug.LogError("You have the limit of wood, can not buy more wood resource");
            }
        }
        else
        {
            Debug.LogError($"Player has not enough money to buy Wood");
        }
    }

    private void BuyStone()
    {
        if (_currentMoney < stoneCost)
        {
            Debug.LogError($"Player has not enough money to buy stone");
            return;
        }
        
        if (_currentStones >= stoneLimit)
        {
            Debug.LogError("You have the limit of stone, can not buy more wood resource");
            return;
        }
        
        _currentMoney -= stoneCost;
        _currentStones++;
        Debug.Log($"You buy stone. current stone: {_currentStones}");
        RegisterData();
    }

    private void EarnMoney()
    {
        _currentMoney += earnMoney;
        Debug.Log($"You earn money!!!. current money: {_currentMoney}");
        RegisterData();
    }

    private void BuildWoodHouse()
    {
        if (_currentWoods < woodHouseCost)
        {
            Debug.LogError("Player has not enough wood to build a wood House");
            return;
        }

        _woodHouses++;
        _currentWoods -= woodHouseCost;
        Debug.Log($"Congratulation, you build a wood House. Current wood houses: {_woodHouses}");
        RegisterData();
    }
    
    private void BuildStoneHouse()
    {
        if (_currentStones < stoneHouseCost)
        {
            Debug.LogError("Player has not enough stones to build a stone House");
            return;
        }

        _stoneHouses++;
        _currentStones -= stoneHouseCost;
        Debug.Log($"Congratulation, you build a stone House. Current stone houses: {_stoneHouses}");
        RegisterData();
    }
    
    private void BuildMixedHouse()
    {
        if (_currentStones < mixedHouseStoneCost)
        {
            Debug.LogError("Player has not enough stones to build a mixed House");
            return;
        }
        
        if (_currentWoods < mixedHouseWoodCost)
        {
            Debug.LogError("Player has not enough wood to build a mixed House");
            return;
        }
        
        _mixedHouses++;
        _currentStones -= mixedHouseStoneCost;
        _currentWoods -= mixedHouseWoodCost;
        
        Debug.Log($"Congratulation, you build a mixed House. Current mixed houses: {_mixedHouses}");
        RegisterData();
    }
    
    private string ShowResources()
    {
        var register = $"woodHouses: {_woodHouses}, stoneHouses: {_stoneHouses}, mixedHouses: {_mixedHouses}, money: {_currentMoney}, stones: {_currentStones}, wood: {_currentWoods}.";
            
        Debug.Log(register);
        return register;
    }

    private void RegisterData()
    {
        _registryList.Add(ShowResources());
    }
    
    private void ShowRegister()
    {
        var i = 1;
        foreach (var register in _registryList)
        {
            Debug.Log($"Data N°{i}: {register}");
            i++;
        }
    }
}
