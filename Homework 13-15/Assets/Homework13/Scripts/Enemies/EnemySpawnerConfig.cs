using UnityEngine;

[CreateAssetMenu (menuName = "EnemySpawnerConfig")]
public class EnemySpawnerConfig : ScriptableObject
{
    [SerializeField] private float _spawnCooldown;

    public float SpawnCooldown => _spawnCooldown;
}
