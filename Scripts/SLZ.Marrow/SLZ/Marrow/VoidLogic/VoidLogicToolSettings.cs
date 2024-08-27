// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.
// SLZ.Marrow, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// SLZ.Marrow.VoidLogic.VoidLogicToolSettings
using System;
using System.Collections.Generic;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

[CreateAssetMenu(fileName = "VoidLogicToolSettings.asset", menuName = "StressLevelZero/VoidLogic/VoidLogic Tool Settings")]
public class VoidLogicToolSettings : ScriptableObject
{
	private Dictionary<string, VoidLogicIcon> _type2Icon;

	private Dictionary<string, VoidLogicIcon> _name2Icon;

	[field: SerializeField]
	public Material LineMaterial { get; internal set; }

	[field: SerializeField]
	public Material IconMaterial { get; internal set; }

	[field: SerializeField]
	public VoidLogicIcon[] Icons { get; internal set; }

	public void OnEnable()
	{
	}

	public bool TryGetIcon(Type type, out VoidLogicIcon icon)
	{
		icon = null;
		return false;
	}

	public VoidLogicIcon GetIcon(Type type)
	{
		return null;
	}

	public bool TryGetIcon(string iconName, out VoidLogicIcon icon)
	{
		icon = null;
		return false;
	}

	public VoidLogicIcon GetIcon(string iconName)
	{
		return null;
	}
}
