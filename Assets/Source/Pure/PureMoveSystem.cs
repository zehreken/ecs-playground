using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace Pure
{
	public class PureMoveSystem : ComponentSystem
	{
		public struct CubeGroup
		{
			public readonly int Length;
			public ComponentDataArray<Speed> speed;
			public ComponentDataArray<Rotation> rotation;
		}

		[Inject] private CubeGroup cubes;

		protected override void OnUpdate()
		{
			for (int i = 0; i < cubes.Length; i++)
			{
				Debug.Log("testing");
			}
		}
	}
}