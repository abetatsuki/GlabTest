using UnityEngine;

public class HealEffect : IEffect
{
    public float healAmount;

    public void Apply(GameObject target)
    {
        Debug.Log($"[HealEffect] {target.name} ‚É {healAmount} ‚Ì‰ñ•œŒø‰Ê‚ğ“K—p‚µ‚Ü‚·");

        var healthSystem = target.GetComponent<IHealthSystem>();
        if (healthSystem != null)
        {
            float beforeHp = healthSystem.CurrentHp;
            healthSystem.Heal(healAmount);
            float afterHp = healthSystem.CurrentHp;
            Debug.Log($"[HealEffect] ‰ñ•œŠ®—¹ {beforeHp} ¨ {afterHp} (‰ñ•œ—Ê: {afterHp - beforeHp})");
        }
        else
        {
            Debug.LogWarning($"[HealEffect] {target.name} ‚ÉIHealthSystem‚ªŒ©‚Â‚©‚è‚Ü‚¹‚ñ");
        }
    }
}