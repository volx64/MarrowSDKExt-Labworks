using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public static class ObjectPathExtensions
	{
		private static IEnumerable<string> ObjectPathComponents(this Transform tf)
		{
			return null;
		}

		[PublicAPI]
		public static string ObjectPath(this Transform tf)
		{
			return null;
		}

		[PublicAPI]
		public static string ObjectPath(this Component c)
		{
			GameObject obj = c.gameObject;
			string path = "/" + obj.name;
			while (obj.transform.parent != null)
			{
				obj = obj.transform.parent.gameObject;
				path = "/" + obj.name + path;
			}
			return path;
		}

		[PublicAPI]
		public static string ObjectPath(this GameObject go)
		{
			return null;
		}
	}
}
