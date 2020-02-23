using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Tobe.Core
{
    public class ProximityWatcherGroup
    {
        [SerializeField] private List<ProximityTrigger> checkPoints;

        public UnityAction<int, ProximityWatcher> OnCheckpointTriggered;

        void Start()
        {
            for (int i = 0; i < checkPoints.Count; i++)
            {
                var checkpoint = checkPoints[i];

                checkpoint.objectEnteredProximity.AddListener((sender, gameObj) =>
                {
                    var item = sender as ProximityTrigger;

                    var index = checkPoints.IndexOf(item);

                    OnCheckpointTriggered?.Invoke(index, item);
                });
            }
        }
    }
}