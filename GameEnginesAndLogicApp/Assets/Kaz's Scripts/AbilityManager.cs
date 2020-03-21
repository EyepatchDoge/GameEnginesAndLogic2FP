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

    public Dictionary<IAbility, bool> abilityDictionary = new Dictionary<IAbility, bool>();

    public List<GameObject> abilityPrefabs;


    private void Awake()
    {
        InitializeDictionary();
    }

    private void InitializeDictionary()
    {
        for (int i = 0; i < abilityPrefabs.Count; i++)
        {
            IAbility variable = abilityPrefabs[i].GetComponent<IAbility>();

            if (!abilityDictionary.ContainsKey(variable))
            {
                abilityDictionary.Add(variable, false);
            }
        }
    }


    public void UpdateDictonary(IAbility ability)
    {
        abilityDictionary[ability] = true;
    }

    public void TestItemAbility()
    {
        testI.PlayCelebrationClip();
    }
}
