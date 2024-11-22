using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> container = new GameContainer<string>();
        container.SetItem("Healing Potion");

        string item = container.GetItem();
        Debug.Log(item);

        string description = GameUtils.DescribeItem(item);
        Debug.Log(description);
    }
}