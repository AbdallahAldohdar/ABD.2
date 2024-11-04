using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    int Multiply(int a, int b)
    {
        return a * b;
    }

    void Start()
    {
      
        for (int i = 1; i <= 10; i++)
        {
            
            int result = Multiply(5, i);
    
            Debug.Log("5 x " + i + " = " + result);
        }
    }

    
}
