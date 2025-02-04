﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCityButton : MonoBehaviour
{
    public void BuildCity()
    {
        HexMap map = GameObject.FindObjectOfType<HexMap>();
        InputController inputController = GameObject.FindObjectOfType<InputController>();
        
        map.SpawnCityAt( map.CityPrefab, GameController.Main.CurrentPeople(), inputController.SelectedUnit.Hex);
    }
}
