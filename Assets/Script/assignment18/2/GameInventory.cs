using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Debug.Log("GameInventory script is running...");

        Inventory potionsInventory = new Inventory();
        potionsInventory.AddItem("Healing Potion");
        potionsInventory.AddItem("Strength Potion");

        Inventory elixirsInventory = new Inventory();
        elixirsInventory.AddItem("Elixir");
        elixirsInventory.AddItem("Dark Elixir");

        Inventory combinedInventory = potionsInventory + elixirsInventory;

        Debug.Log("Combined Inventory:");
        combinedInventory.ShowItems();
    }
}
