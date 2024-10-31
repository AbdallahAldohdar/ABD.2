using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class abood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter = 0 ;
        while (counter <= 20)
        {
        int randomNumber = Random.Range(1,21);
        Debug.Log(randomNumber);
        counter++;
        if (randomNumber==5) continue;
        if (randomNumber==15) break;
        Debug.Log("Abdallah");
        }
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string sentence = "";

        int wordCount = 0;
        
        while (wordCount < 7)
        {
            int index = Random.Range(0,words.Length); // Get a random index from the array
            sentence += words[index] + " , "; // Add the chosen word to the sentence
            wordCount++;
        }

        Debug.Log("Funny Sentence: " + sentence.Trim());
    }

    
}
