using System;
using System.Collections;
using UnityEngine;
using Zenject;

public class EnemySpawner 
{
    [SerializeField] private float _spawnCooldown;

    private SpawnPointsHolder _spawnPoints;
    private EnemyFactory _enemyFactory;
    private Coroutine _spawn;
    private MonoBehaviour _monoBehaviour;
    private EnemySpawnerConfig _enemySpawnerConfig;

    [Inject]
    private void Construct(EnemyFactory enemyFactory, EnemySpawnerConfig enemySpawnerConfig, SpawnPointsHolder spawnPointsHolder, MonoBehaviour monoBehaviour)
    {
        _enemyFactory = enemyFactory;
        _enemySpawnerConfig = enemySpawnerConfig;
        _spawnCooldown = enemySpawnerConfig.SpawnCooldown;
        _spawnPoints = spawnPointsHolder;
        _monoBehaviour = monoBehaviour;
    }

    public void StartWork()
    {
        StopWork();

        _spawn = _monoBehaviour.StartCoroutine(Spawn());
    }

    public void StopWork()
    {
        if (_spawn != null)
            _monoBehaviour.StopCoroutine(_spawn);
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            Enemy enemy = _enemyFactory.Get((EnemyType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
            enemy.MoveTo(_spawnPoints.SpawnPoints[UnityEngine.Random.Range(0, _spawnPoints.SpawnPoints.Count)].position);
            yield return new WaitForSeconds(_spawnCooldown);
        }
    }
}
