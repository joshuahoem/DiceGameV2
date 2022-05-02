using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceForLogic : MonoBehaviour
{
    [SerializeField] GameObject[] dice;
    List<int> diceValues = new List<int>();

    public void CheckDiceValues()
    {
        //adds all selected dice values to a list
        foreach (GameObject singleDice in dice)
        {
            if (singleDice.GetComponent<Dice>().selected)
            {
                diceValues.Add(singleDice.GetComponent<Dice>().CheckDiceValue());
            }
        }

        //code that handles dice calculations
        foreach (int number in diceValues)
        {
            Debug.Log(number);
        }

        //last step to clear before button is pressed again
        diceValues.Clear();
    }

}
