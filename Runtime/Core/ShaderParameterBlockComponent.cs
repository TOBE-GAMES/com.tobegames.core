using System;
using UnityEngine;

namespace Tobe.Core
{
    [RequireComponent(typeof(Renderer))]
    public class ShaderParameterBlockComponent : MonoBehaviour
    {
        [HideInInspector] public ColorShaderParameter[] colorShaderParameters;
        [HideInInspector] public IntShaderParameter[] intShaderParameters;
        [HideInInspector] public FloatShaderParameter[] floatShaderParameters;

        private MaterialPropertyBlock _materialPropertyBlock;

        private Renderer _rendererComponent;


        private void Awake()
        {
            _rendererComponent = GetComponent<Renderer>();
            
            _materialPropertyBlock = new MaterialPropertyBlock();

            RefreshParametersBlock();
        }

        public void RefreshParametersBlock()
        {
            foreach (var parameterBase in colorShaderParameters)
            {
                if (string.IsNullOrEmpty(parameterBase.parameterName)) continue;

                parameterBase.ApplyValue(_materialPropertyBlock);
            }

            foreach (var floatShaderParameter in floatShaderParameters)
            {
                if (string.IsNullOrEmpty(floatShaderParameter.parameterName)) continue;

                floatShaderParameter.ApplyValue(_materialPropertyBlock);
            }

            foreach (var intShaderParameter in intShaderParameters)
            {
                if (string.IsNullOrEmpty(intShaderParameter.parameterName)) continue;

                intShaderParameter.ApplyValue(_materialPropertyBlock);
            }
            
            _rendererComponent.SetPropertyBlock(_materialPropertyBlock);
        }
    }
}