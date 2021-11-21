using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HorrorVR
{
    public interface IInspectable
    {
        bool DisableAfterNextUse { get; }
        float DistanceThreshold { get; }
        float AngleThreshold { get; }
        Transform Transform { get; }
        void OnInspect ();
        void OnInspectEnd ();
    }
}
