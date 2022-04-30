using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [SerializeField] GameObject[] diceFaces;
    GameObject diceValue;
    Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //do not check at the start - check only once then stop checking?
        CheckDice();
    }


    public GameObject CheckDiceValue()
    {
        var dicePos = -99999999f;

        foreach (GameObject dice in diceFaces)
        {
            if (dice.transform.position.y > dicePos)
            {
                dicePos = dice.transform.position.y;
                diceValue = dice;
            }
        }
        return diceValue;
    }

    private void CheckDice()
    {
        
        if (rb.velocity.y == 0 && rb.velocity.x == 0 && rb.velocity.z == 0)
        {
            Debug.Log(CheckDiceValue().name);
        }
    }
}
