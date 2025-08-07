using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ItemCollector collector;
    [SerializeField] private ItemCombiner combiner;

    private void Start()
    {
        collector.OnItemCollected += combiner.OnItemCollected;
    }

    private void OnDestroy()
    {
        collector.OnItemCollected -= combiner.OnItemCollected;
    }
}
