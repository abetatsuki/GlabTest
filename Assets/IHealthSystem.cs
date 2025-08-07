// === IHealthSystem.cs �t�@�C�� ===
public interface IHealthSystem
{
    float CurrentHp { get; }
    float MaxHp { get; }
    void Heal(float amount);
    void TakeDamage(float amount);
}