using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Player1", 80);
        Enemy enemy = new Enemy("Enemy1", 100);

        Debug.Log($"Player: {player.Name}, Health: {player.Health}");
        Debug.Log($"Enemy: {enemy.Name}, Health: {enemy.Health}");

        player.Heal(15);
        Debug.Log($"After healing, Player Health: {player.Health}");

        enemy.Attack(player, 20);
        Debug.Log($"After attack, Player Health: {player.Health}");
    }

}
