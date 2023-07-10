using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCounter : MonoBehaviour
{
    public static bool questSolved = false;

    void Update()
    {
        if (gameObject.transform.childCount == 0)
        {
            questSolved = true; 
        }
    }

    public static bool isQuestSolved()
    {
        return questSolved;
    }
}
