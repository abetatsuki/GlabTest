using UnityEngine;

public class HealEffect : IEffect
{
    public float healAmount;

    public void Apply(GameObject target)
    {
        Debug.Log($"[HealEffect] {target.name} �� {healAmount} �̉񕜌��ʂ�K�p���܂�");

        var healthSystem = target.GetComponent<IHealthSystem>();
        if (healthSystem != null)
        {
            float beforeHp = healthSystem.CurrentHp;
            healthSystem.Heal(healAmount);
            float afterHp = healthSystem.CurrentHp;
            Debug.Log($"[HealEffect] �񕜊��� {beforeHp} �� {afterHp} (�񕜗�: {afterHp - beforeHp})");
        }
        else
        {
            Debug.LogWarning($"[HealEffect] {target.name} ��IHealthSystem��������܂���");
        }
    }
}