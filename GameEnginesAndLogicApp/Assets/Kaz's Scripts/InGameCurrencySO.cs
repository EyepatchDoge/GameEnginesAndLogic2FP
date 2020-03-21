using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//scriptable object so that if we re-name curency it is easier, also if we add any more currency 
[CreateAssetMenu(fileName = "GameCurrencySO", menuName = "ScriptableObjects/GameCurency", order = 1)]
public class InGameCurrencySO : ScriptableObject
{
    public string currencyName;
    public Sprite currency;
    public int currencyAmount;
}
