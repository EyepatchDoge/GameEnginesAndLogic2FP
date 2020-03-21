using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameCurrencySO", menuName = "ScriptableObjects/GameCurency", order = 1)]
public class InGameCurrencySO : ScriptableObject
{
    public string currencyName;
    public Sprite currency;
    public int currencyAmount;
}
