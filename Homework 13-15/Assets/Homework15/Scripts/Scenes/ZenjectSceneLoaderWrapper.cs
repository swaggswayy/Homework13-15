using System;
using UnityEngine.SceneManagement;
using Zenject;

public class ZenjectSceneLoaderWrapper 
{
    private ZenjectSceneLoader _zenjectSceneLoader;

    public ZenjectSceneLoaderWrapper(ZenjectSceneLoader zenjectSceneLoader)
    {
        _zenjectSceneLoader = zenjectSceneLoader;
    }

    public void Load(ScenesEnum scene, Action<DiContainer> action = null)
    {
        _zenjectSceneLoader.LoadScene((int)scene, LoadSceneMode.Single, container => action?.Invoke(container));
    }
}
