using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Character[] characters = new Character[2];
            characters[0] = new Soldier("Soldier1", 80, new Position(1, 2, 3));
            characters[1] = new Officer("Officer1", 90, new Position(4, 5, 6));

            foreach (var character in characters)
            {
                character.DisplayInfo();
            }

            var soldier = characters[0];
            var officer = characters[1];
            officer.Attack(20, soldier);

            Debug.Log($"Soldier's Health after attack: {((Soldier)soldier).Health}");
        }
    }
}