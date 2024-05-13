using UnityEngine;
using UnityEngine.UI;

public class MoneyTreeSystem : MonoBehaviour
{
    // Public variables accessible from the Unity Editor
    public float startingMoney = 100f; // Initial amount of money
    public Text piggieBankText; // Reference to the UI Text component

    // Private variables
    private float money; // Current amount of money

    // Awake is called before Start
    void Awake()
    {
        // Initialize money to the starting amount
        money = startingMoney;
    }

    // Update is called once per frame
    void Update()
    {
        // Update the text display with the current amount of money
        UpdatePiggieBankText();
    }

    // Function to update the UI Text component with the current money amount
    void UpdatePiggieBankText()
    {
        // Check if the reference to the UI Text component is not null
        if (piggieBankText != null)
        {
            // Update the text to display the current money amount
            piggieBankText.text = "$1 " + money.ToString("F2"); // Formats money to display two decimal places
        }
        else
        {
            // Print a warning if the UI Text reference is missing
            Debug.LogWarning("PiggieBankText reference is missing!");
        }
    }

    // Function to add money to the player's balance
    public void AddMoney(float amount)
    {
        money += amount;
    }

    // Function to subtract money from the player's balance
    public void SubtractMoney(float amount)
    {
        // Ensure the player has enough money before subtracting
        if (money >= amount)
        {
            money -= amount;
        }
        else
        {
            // Print a warning if the player doesn't have enough money
            Debug.LogWarning("Not enough money to subtract!");
        }
    }
}
