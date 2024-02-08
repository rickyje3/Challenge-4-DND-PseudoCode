public dictionary[] class;
public string playerClass;
bool isDwarf;
bool isTough;
int healthPoints;
public int playerLevel;
string playerName;
public int[] abilityScoreModifier;

public class DiceCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void update()
    {
        Debug.Log("Your total hit points is " + healthPoints);
    }

    void fixedDiceRoll()
    {
        //This will generate the average of the character classes hit die.
    }

    void randomDiceRoll()
    {
    //This will generate a random die value that is added to your characters hit die
    class[playerClass] = random.next(int1, class.) 
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

void Dictionary<string, int> class = new Dictionary<string, int>()
{
    "Artificer" 8,
    "Barbarian" 12,
    "Bard" 8,
    "Cleric" 8,
    "Druid" 8,
    "Fighter" 10,
    "Monk" 8,
    "Ranger" 10,
    "Rogue" 8,
    "Paladin" 10,
    "Sorcerer" 6,
    "Wizard" 6,
    "Warlock" 8
};

void Array[,] abilityScoreModifier = new int[16, 2]
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
    {11, 0}.
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