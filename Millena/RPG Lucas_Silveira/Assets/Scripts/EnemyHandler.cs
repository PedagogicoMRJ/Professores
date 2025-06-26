using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour, IInteractable
{
    public bool isEnemyDead;
    public string enemyName;
    public int enemyLevel;
    public int enemyHealth;
    public int enemyMaxHealth;
    public int enemyDamage;
    public int enemyExperience;
    private Animator enemyAnim;

    void Start() // Corrigido "start" para "Start"
    {
        isEnemyDead = false;
        enemyAnim = GetComponentInChildren<Animator>();
    }

    public bool TakeDamage(int damage)
    {
        Debug.Log("The enemy takes damage");
        enemyHealth -= damage;
        if (enemyHealth <= 0)
        {
            EnemyDie();
            return true;
        }
        return false;
    }

    void EnemyDie()
    {
        Debug.Log("The Enemy died");
        Destroy(gameObject, 2f);
    }

    public void Interact()
    {
        Debug.Log("The enemy is ready to fight");
        BattleSystem.Instance.SetFightingEnemy(this); // novo método mais seguro
    }
}