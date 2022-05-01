using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    //Numbers
    [SerializeField] float delayWaitTime = 2f;

    //States
    bool delayedCheck = false;

    //Cache
    [SerializeField] GameObject[] diceFaces;
    GameObject diceValue;
    Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(DelayCheck());
    }

    IEnumerator DelayCheck()
    {
        yield return new WaitForSeconds(delayWaitTime);
        delayedCheck = true;
    }

    private void FixedUpdate()
    {
        if (!delayedCheck) {return;}
        CheckDice(); 
    }
    
    private void CheckDice()
    {
        
        if (rb.velocity.magnitude <= Mathf.Epsilon) 
        {
            Debug.Log(CheckDiceValue());
            delayedCheck = false;
        }
    }


    public int CheckDiceValue()
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
        
        for (int i=0; i<(diceFaces.Length-1); i++)
        {
            if (diceValue.name == diceFaces[i].name)
            {
                return (i+1);
            }
        }

        return 0;
    }

}
