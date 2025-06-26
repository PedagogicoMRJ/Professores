using System.Collections;
using UnityEngine;

public enum BattleStage { WATING, START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public static BattleSystem Instance { get; private set; } // Singleton

    public BattleStage stage;
    BattleHUD battleHUD;
    EnemyHandler enemyUnit;
    PlayerHandler playerUnit;
    public GameObject specialButton;
    public bool isFighting;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        isFighting = false;
        stage = BattleStage.WATING;
        battleHUD = GameObject.FindGameObjectWithTag("BattleHUD").GetComponent<BattleHUD>();
        playerUnit = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHandler>();
        specialButton.SetActive(false);
    }

    private void Update()
    {
        if (!isFighting)
        {
            isFighting = playerUnit.isFighting;
            if (isFighting)
            {
                StartFight();
            }
        }
    }

    public void SetFightingEnemy(EnemyHandler enemy)
    {
        enemyUnit = enemy;
        enemyUnit.tag = "Untagged"; // Evita interferências futuras
        playerUnit.isFighting = true;
    }

    public void StartFight()
    {
        Debug.Log("The fight began");
        stage = BattleStage.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        battleHUD.SetHUD(enemyUnit, playerUnit);
        battleHUD.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        stage = BattleStage.PLAYERTURN;
        PlayerTurn();
    }

    void PlayerTurn() => Debug.Log("Choose an action");

    public void AttackButton()
    {
        if (stage != BattleStage.PLAYERTURN) return;
        StartCoroutine(PlayerAttack(playerUnit.playerDamage));
    }

    public void SpecialAttackButton()
    {
        if (stage != BattleStage.PLAYERTURN) return;
        StartCoroutine(PlayerAttack(playerUnit.playerDamage * 2));
    }

    public void HealButton()
    {
        if (stage != BattleStage.PLAYERTURN) return;
        StartCoroutine(PlayerHeal());
    }

    IEnumerator PlayerAttack(int damage)
    {
        Debug.Log("The Player attacks the Enemy");
        bool isDead = enemyUnit.TakeDamage(damage);
        yield return new WaitForSeconds(1f);
        battleHUD.SetHP(enemyUnit.enemyHealth, playerUnit.playerHealth);
        yield return new WaitForSeconds(1f);
        stage = isDead ? BattleStage.WON : BattleStage.ENEMYTURN;
        if (isDead)
            StartCoroutine(EndBattle());
        else
            StartCoroutine(EnemyTurn());
    }

    IEnumerator PlayerHeal()
    {
        Debug.Log("The Player heals");
        playerUnit.Heal();
        yield return new WaitForSeconds(1f);
        battleHUD.SetHP(enemyUnit.enemyHealth, playerUnit.playerHealth);
        yield return new WaitForSeconds(1f);
        stage = BattleStage.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }

    IEnumerator EnemyTurn()
    {
        Debug.Log("The Enemy attacks");
        yield return new WaitForSeconds(1f);

        int enemyAction = 1; // fixado para evitar loop infinito
        bool isDead = playerUnit.TakeDamage(enemyUnit.enemyDamage);
        yield return new WaitForSeconds(1f);
        battleHUD.SetHP(enemyUnit.enemyHealth, playerUnit.playerHealth);
        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            Debug.Log("You died");
            stage = BattleStage.LOST;
            StartCoroutine(EndBattle());
        }
        else
        {
            Debug.Log("Player Turn");
            stage = BattleStage.PLAYERTURN;
            PlayerTurn();
        }
    }

    IEnumerator EndBattle()
    {
        if (stage == BattleStage.WON)
        {
            Debug.Log("You Won the Battle");
            playerUnit.isFighting = false;
            isFighting = false;
            playerUnit.GainExperience(enemyUnit.enemyExperience);
            if (playerUnit.playerLevel == 10) EnableSpecialAttack();
        }
        else if (stage == BattleStage.LOST)
        {
            Debug.Log("You Lost the Battle");
            playerUnit.isFighting = false;
            isFighting = false;
        }
        yield return new WaitForSeconds(1f);
        stage = BattleStage.WATING;
        battleHUD.gameObject.SetActive(false);
    }

    void EnableSpecialAttack() => specialButton.SetActive(true);
}
