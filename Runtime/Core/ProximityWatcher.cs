using System;
using UnityEngine;
using UnityEngine.Events;


namespace Tobe.Core
{
    [Serializable]
    public class ProximityWatcherEventHandler : UnityEvent<ProximityWatcher, GameObject>
    {
        
    }

    public abstract class ProximityWatcher : MonoBehaviour
    {
        public string[] watchedTags;

        public ProximityWatcherEventHandler objectEnteredProximity;

        public ProximityWatcherEventHandler objectExitedProximity;

        public bool debug;

        public bool isInProximity;

        [SerializeField]
        private GameObject lastProximityGameObject;

        protected virtual bool OnObjectEnteredProximity(GameObject e)
        {
            if (debug)
                print("Proximity " + gameObject + " checking " + e);

            if (watchedTags.Length > 0 && !TagHelper.Contains(watchedTags, e.tag)) return false;

            var proxy = e.GetComponent<ColliderProxy>();
            if (proxy)
            {
                e = proxy.root;
            }
            
            lastProximityGameObject = e;

            isInProximity = true;

            if (debug)
                print("Proximity " + gameObject + " tracking " + e);

            objectEnteredProximity?.Invoke(this,e);

            return true;
        }

        protected virtual bool OnObjectExitedProximity(GameObject e)
        {
            if (debug)
                print("Proximity " + gameObject + " checking " + e);

            var proxy = e.GetComponent<ColliderProxy>();
            if (proxy)
            {
                e = proxy.root;
            }

            if (e == null || e != lastProximityGameObject) return false;

            lastProximityGameObject = null;

            isInProximity = false;

            if (debug)
                print("Proximity " + gameObject + " loosing " + e);

            objectExitedProximity?.Invoke(this, e);

            return true;
        }
    }
}