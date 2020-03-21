using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this is the purchaser script that will be used in the store for in game currency purchases
/// </summary>


public class AbilityPurchases : MonoBehaviour
{
    public InGameCurrencySO spaceMoney;
    public AbilityManager aManager;
    
    public void BuyAbility(AbilitySO SO)
    {
        if(spaceMoney.currencyAmount >= SO.cost)
        {
            aManager.UpdateDictonary(SO, true);

            spaceMoney.currencyAmount -= SO.cost;
        }
    }
}
