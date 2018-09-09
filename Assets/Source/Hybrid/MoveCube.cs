using Unity.Entities;
using UnityEngine;

namespace Hybrid
{
	public class MoveCube : MonoBehaviour
	{
		public float Speed;
	}

	class MoveSystem : ComponentSystem
	{
		struct Group
		{
			// Define what components are required for this 
			// ComponentSystem to handle them.
			public Transform Transform;
			public MoveCube MoveCube;
		}

		protected override void OnUpdate()
		{
			// We can immediately see a first optimization.
			// We know delta time is the same between all rotators,
			// so we can simply keep it in a local variable 
			// to get better performance.

			// ComponentSystem.GetEntities<Group> 
			// lets us efficiently iterate over all GameObjects
			// that have both a Transform & Rotator component 
			// (as defined above in Group struct).
			foreach (var e in GetEntities<Group>())
			{
				e.Transform.Rotate(Vector3.left * e.MoveCube.Speed * Time.deltaTime);
			}
		}
	}
}