// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// SLZ.Marrow, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// SLZ.Marrow.VoidLogic.VoidLogicIcon
using System;
using System.Diagnostics;
using SLZ.Marrow.Utilities;
using UnityEngine;

[Serializable]
public class VoidLogicIcon
{
	[field: SerializeField]
	[field: ReadOnly(false)]
	public string Script { get; internal set; }

	[field: SerializeField]
	[field: ReadOnly(false)]
	public string Name { get; internal set; }

	[field: SerializeField]
	[field: ReadOnly(false)]
	public int Index { get; internal set; }

	[Conditional("UNITY_EDITOR")]
	public void UpdateIcon()
	{
	}
}
