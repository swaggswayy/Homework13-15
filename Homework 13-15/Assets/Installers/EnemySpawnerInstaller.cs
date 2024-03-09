using UnityEngine;
using Zenject;

public class EnemySpawnerInstaller : MonoInstaller
{
    [SerializeField] private EnemySpawnerConfig _config;
    [SerializeField] private SpawnPointsHolder _spawnPointsHolder;
    [SerializeField] private MonoBehaviour _monoBehaviour;

    public override void InstallBindings()
    {
        Container.Bind<EnemyFactory>().AsSingle();
        Container.Bind<EnemySpawnerConfig>().FromInstance(_config);
        Container.Bind<SpawnPointsHolder>().FromInstance(_spawnPointsHolder);
        Container.Bind<MonoBehaviour>().FromInstance(_monoBehaviour);
        Container.Bind<EnemySpawner>().AsSingle();
    }
}
