// === 9. PlayerHealth �N���X�i�v���C���[�̗̑͊Ǘ��̐Ӗ��̂݁j ===
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
            Debug.LogWarning($"[PlayerHealth] �����ȉ񕜗�: {amount}");
            return;
        }

        float oldHp = currentHp;
        currentHp = Mathf.Min(currentHp + amount, maxHp);
        float actualHeal = currentHp - oldHp;

        Debug.Log($"[PlayerHealth] �񕜏��� - �v��: {amount}, ����: {actualHeal}, HP: {oldHp} �� {currentHp}");
        OnHealthChanged();
    }

    public void TakeDamage(float amount)
    {
        if (amount <= 0)
        {
            Debug.LogWarning($"[PlayerHealth] �����ȃ_���[�W��: {amount}");
            return;
        }

        float oldHp = currentHp;
        currentHp = Mathf.Max(currentHp - amount, 0);
        Debug.Log($"[PlayerHealth] �_���[�W���� - �_���[�W: {amount}, HP: {oldHp} �� {currentHp}");
        OnHealthChanged();
    }

    private void OnHealthChanged()
    {
        Debug.Log($"[PlayerHealth] ����HP: {currentHp}/{maxHp} ({(currentHp / maxHp) * 100:F1}%)");
    }
}