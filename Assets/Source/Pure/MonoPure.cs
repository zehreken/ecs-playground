using Unity.Entities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pure
{
	public class MonoPure : MonoBehaviour
	{
		private void Start()
		{
			var entityManager = World.Active.GetOrCreateManager<EntityManager>();

			for (int i = 0; i < 150; i++)
			{
				for (int j = 0; j < 100; j++)
				{
					var cubeEntity = entityManager.CreateEntity(
						ComponentType.Create<Speed>(),
						ComponentType.Create<Transform>());

					entityManager.SetComponentData(cubeEntity, new Speed {Value = 100});
				}
			}
		}

		void Update()
		{
			if (Input.GetKeyUp(KeyCode.Alpha1))
			{
				SceneManager.LoadScene(0);
			}

			if (Input.GetKeyUp(KeyCode.Alpha2))
			{
				SceneManager.LoadScene(1);
			}

			if (Input.GetKeyUp(KeyCode.Alpha3))
			{
				SceneManager.LoadScene(2);
			}
		}
	}
}