﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Inventory
{
    #region 单例模式
    private static Chest _instance;
    public static Chest Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.Find("ChestPanel").GetComponent<Chest>();
            }

            return _instance;
        }
    }
    #endregion
}
