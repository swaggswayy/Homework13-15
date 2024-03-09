using UnityEngine;
using Zenject;

public class SimulationDefeat : MonoBehaviour
{
    [Inject] private Level _level;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _level.OnDefeat();
    }
}
