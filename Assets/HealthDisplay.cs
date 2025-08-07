// === 9. HealthDisplay クラス（体力表示の責務のみ） ===
using UnityEngine;
using UnityEngine.UI;
public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Text healthText;
    private IHealthSystem healthSystem;

    private void Start()
    {
        healthSystem = FindObjectOfType<PlayerHealth>();
    }

    private void Update()
    {
        if (healthSystem == null) return;

        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        float healthPercentage = healthSystem.CurrentHp / healthSystem.MaxHp;

        if (healthSlider != null)
            healthSlider.value = healthPercentage;

        if (healthText != null)
            healthText.text = $"{healthSystem.CurrentHp:F0}/{healthSystem.MaxHp:F0}";
    }
}