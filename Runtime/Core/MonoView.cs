using System;
using UnityEngine;

namespace Tobe.Core
{
   public abstract class MonoView<TView> : MonoBehaviour, IView where TView : IView
   {
      
   }
}