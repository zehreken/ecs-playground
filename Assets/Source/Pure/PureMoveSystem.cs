using Unity.Entities;
using UnityEngine;

namespace Pure
{
	public class PureMoveSystem : ComponentSystem
	{
		public struct CubeGroup
		{
			public int Length;
			public ComponentDataArray<Speed> speed;
			public ComponentDataArray<Trns> transform;
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