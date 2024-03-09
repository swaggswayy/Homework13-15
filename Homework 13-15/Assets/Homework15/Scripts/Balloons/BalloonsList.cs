using System.Collections.Generic;
using UnityEngine;

public class BalloonsList : MonoBehaviour
{
    [SerializeField] private List<Balloon> _balloons;

    public List<Balloon> Balloons => _balloons;
}
