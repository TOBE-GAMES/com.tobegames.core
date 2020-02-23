using UnityEngine;

namespace Tobe.Core
{
    public class ProximityTrigger : ProximityWatcher
    {
        public Collider triggeredCollider;

        private void OnTriggerEnter(Collider other)
        {
            if (OnObjectEnteredProximity(other.gameObject))
            {
                triggeredCollider = other;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (OnObjectExitedProximity(other.gameObject))
            {
                triggeredCollider = null;
            }
        }


        private void OnTriggerStay(Collider other)
        {
            if (isInProximity)
            {
                triggeredCollider = other;
            }
        }
    }
}