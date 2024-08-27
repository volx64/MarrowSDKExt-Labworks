using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
    public static class VL
    {
        private static NodeState _badState;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddNode(IVoidLogicNode node)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void RemoveNode(IVoidLogicNode node)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void EnableNode(IVoidLogicNode node)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DisableNode(IVoidLogicNode node)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UpdateConnection(InputPortReference to, OutputPortReference from)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UpdateConnection(IVoidLogicSink sink, uint inputIndex, OutputPortReference from)
        {
        }

        public static bool TryGetValue(this OutputPortReference portReference, out float value)
        {
            value = default(float);
            return false;
        }

        public static float GetValue(this OutputPortReference portReference, float defaultValue = 0f)
        {
            return 0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OutputPortReference GetInputAtIndex(this IVoidLogicSink sink, uint index)
        {
            return default(OutputPortReference);
        }
    }
}
