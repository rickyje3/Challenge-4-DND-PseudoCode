using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieCalculator : MonoBehaviour
{
    public string playerClass;
    public int conScore;
    public bool isDwarf;
    public bool isTough;
    public int healthPoints;
    public int playerLevel;
    public string playerName;
    public bool isHPAveraged;

    private int consScoreMod;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            Debug.Log("My character " + playerName + " is a level " + playerLevel + playerClass + " with a CON score of " + conScore);
            Debug.Log("My Hit Point value is " + healthPoints);
        }

        void fixedDiceRoll()
        {
            //This will generate the average of the character classes hit die.
            isHPAveraged = false;
        }

        void randomDiceRoll()
        {
            //This will generate a random die value that is added to your characters hit die
            isHPAveraged = true;
        }
    }
  
    void math()
    {
        consScoreMod = abilityScoreModifier[conScore - 1, 1];
    }

void classHealthBoosts()
{
    if (isDwarf == true)
    {
        healthPoints += 1 * playerLevel;
    }

    if (isTough == true)
    {
        healthPoints += 2 * playerLevel;
    }
}

Dictionary<string, int > classes = new Dictionary<string, int>()
{
    {"Artificer", 8},
    {"Barbarian", 12},
    {"Bard", 8},
    {"Cleric", 8},
    {"Druid", 8},
    {"Fighter", 10},
    {"Monk", 8},
    {"Ranger", 10},
    {"Rogue", 8},
    {"Paladin", 10},
    {"Sorcerer", 6},
    {"Wizard", 6},
    {"Warlock", 8}
};

int[,] abilityScoreModifier = new int[30, 2]
{
    {1, -5},
    {2, -4},
    {3, -4},
    {4, -3},
    {5, -3},
    {6, -2},
    {7, -2},
    {8, -1},
    {9, -1},
    {10, 0},
    {11, 0},
    {12, 1},
    {13, 1},
    {14, 2},
    {15, 2},
    {16, 3},
    {17, 3},
    {18, 4},
    {19, 4},
    {20, 5},
    {21, 5},
    {22, 6},
    {23, 6},
    {24, 7},
    {25, 7},
    {26, 8},
    {27, 8},
    {28, 9},
    {29, 9},
    {30, 10}
};
}
