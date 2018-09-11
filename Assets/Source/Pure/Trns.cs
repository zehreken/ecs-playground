using Unity.Entities;
using UnityEngine;

namespace Pure
{
	public struct Trns : IComponentData
	{
		public Transform Value;
	}
}