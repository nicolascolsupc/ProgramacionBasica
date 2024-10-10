using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace POO
{
    public class ResourceManager : MonoBehaviour
    {
        private Resource _currentWoods = new Resource("Wood");
        private Resource _currentStones = new Resource("Stone");
        private int _currentMoney;
        private House _woodHouses;
        private House _stoneHouses;
        private int _mixedHouses;
        private List<string> _registryList = new List<string>();
        private HouseBuilder _houseBuilder = new HouseBuilder();

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

            _woodHouses = new House("Wood house", woodHouseCost);
            _stoneHouses = new House("Stone House", stoneHouseCost);
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
                _houseBuilder.Build(_woodHouses, _currentWoods);
                RegisterData();
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                _houseBuilder.Build(_stoneHouses, _currentStones);
                RegisterData();
            }
            
            if (Input.GetKeyDown(KeyCode.M))
            {
                //TODO: Build a mixed house
                //BuildMixedHouse();
                RegisterData();
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
                if (_currentWoods.GetQuantity() < woodLimit)
                {
                    _currentMoney -= woodCost;
                    _currentWoods.Add(1);
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
            
            if (_currentStones.GetQuantity() >= stoneLimit)
            {
                Debug.LogError("You have the limit of stone, can not buy more wood resource");
                return;
            }
            
            _currentMoney -= stoneCost;
            _currentStones.Add(1);
            Debug.Log($"You buy stone. current stone: {_currentStones}");
            RegisterData();
        }

        private void EarnMoney()
        {
            _currentMoney += earnMoney;
            Debug.Log($"You earn money!!!. current money: {_currentMoney}");
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
}
