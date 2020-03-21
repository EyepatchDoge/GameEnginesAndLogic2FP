using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is responsible for organizing all the other ability scripts
/// This is so the puchasing script does not get filled with to many unessecary scripts 
/// </summary>
/// 



public class AbilityManager : MonoBehaviour
{
    public TestItem testI;

    public Dictionary<AbilitySO, bool> abilityDictionary = new Dictionary<AbilitySO, bool>();

    public List<AbilitySO> abilitySOs;


    private void Awake()
    {
        InitializeDictionary();
    }

    private void InitializeDictionary()
    {
        for (int i = 0; i < abilitySOs.Count; i++)
        {
            AbilitySO variable = abilitySOs[i];

            if (!abilityDictionary.ContainsKey(variable))
            {
                abilityDictionary.Add(variable, false);
            }
        }
    }


    public void UpdateDictonary(AbilitySO ability, bool value)
    {
        abilityDictionary[ability] = value;
    }

    public void TestItemAbility()
    {
        testI.PlayCelebrationClip();
    }


    [ContextMenu("Apply Abilities")]
    public void ApplyAbilities()
    {
        foreach (var ability in abilityDictionary)
        {
            if(ability.Value == true)
            {
                GameObject go = Instantiate(ability.Key.scriptPrefab);
                go.GetComponent<IAbility>().UseAbility();
                UpdateDictonary(ability.Key, false);
            }
        }
    }
}
