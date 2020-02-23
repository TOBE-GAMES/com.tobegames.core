using UnityEngine;

namespace Tobe.Core
{
    public class ProximityCollision : ProximityWatcher
    {
        public Collision collisionObject;

        private void OnCollisionEnter(Collision other)
        {
            if (OnObjectEnteredProximity(other.gameObject))
            {
                collisionObject = other;
            }
        }

        private void OnCollisionExit(Collision other)
        {
            if (OnObjectExitedProximity(other.gameObject))
            {
                collisionObject = other;
            }            
        }

        private void OnCollisionStay(Collision other)
        {
            if (isInProximity)
            {
                collisionObject = other;
            }
        }
    }
}