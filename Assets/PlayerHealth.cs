// === 9. PlayerHealth クラス（プレイヤーの体力管理の責務のみ） ===
using UnityEngine;
public class PlayerHealth : MonoBehaviour, IHealthSystem
{
    [SerializeField] private float maxHp = 100f;
    [SerializeField] private float currentHp = 50f;

    public float CurrentHp => currentHp;
    public float MaxHp => maxHp;

    public void Heal(float amount)
    {
        if (amount <= 0)
        {
            Debug.LogWarning($"[PlayerHealth] 無効な回復量: {amount}");
            return;
        }

        float oldHp = currentHp;
        currentHp = Mathf.Min(currentHp + amount, maxHp);
        float actualHeal = currentHp - oldHp;

        Debug.Log($"[PlayerHealth] 回復処理 - 要求: {amount}, 実際: {actualHeal}, HP: {oldHp} → {currentHp}");
        OnHealthChanged();
    }

    public void TakeDamage(float amount)
    {
        if (amount <= 0)
        {
            Debug.LogWarning($"[PlayerHealth] 無効なダメージ量: {amount}");
            return;
        }

        float oldHp = currentHp;
        currentHp = Mathf.Max(currentHp - amount, 0);
        Debug.Log($"[PlayerHealth] ダメージ処理 - ダメージ: {amount}, HP: {oldHp} → {currentHp}");
        OnHealthChanged();
    }

    private void OnHealthChanged()
    {
        Debug.Log($"[PlayerHealth] 現在HP: {currentHp}/{maxHp} ({(currentHp / maxHp) * 100:F1}%)");
    }
}