using Unity.Entities;
using UnityEngine;

class Rotator : MonoBehaviour
{
	// The data - editable in the inspector
	public float Speed;
}

class RotatorSystem : ComponentSystem
{
	struct Group
	{
		// Define what components are required for this 
		// ComponentSystem to handle them.
		public Transform Transform;
		public Rotator Rotator;
	}

	override protected void OnUpdate()
	{
		// We can immediately see a first optimization.
		// We know delta time is the same between all rotators,
		// so we can simply keep it in a local variable 
		// to get better performance.
		float deltaTime = Time.deltaTime;

		// ComponentSystem.GetEntities<Group> 
		// lets us efficiently iterate over all GameObjects
		// that have both a Transform & Rotator component 
		// (as defined above in Group struct).
		foreach (var e in GetEntities<Group>())
		{
			e.Transform.rotation *= Quaternion.AngleAxis(e.Rotator.Speed * deltaTime, Vector3.up);
		}
	}
}