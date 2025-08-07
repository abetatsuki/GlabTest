// === IHealthSystem.cs ƒtƒ@ƒCƒ‹ ===
public interface IHealthSystem
{
    float CurrentHp { get; }
    float MaxHp { get; }
    void Heal(float amount);
    void TakeDamage(float amount);
}