using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mono
{
	public class MonoStart : MonoBehaviour
	{
		public GameObject Cube;

		void Start()
		{
			for (int i = 0; i < 150; i++)
			{
				for (int j = 0; j < 100; j++)
				{
					Instantiate(Cube, new Vector3(-74.5f + i, -49.5f + j, 0f), Quaternion.identity);
				}
			}
		}

		void Update()
		{
			if (Input.GetKeyUp(KeyCode.Alpha0))
			{
				SceneManager.LoadScene(0);
			}
			if (Input.GetKeyUp(KeyCode.Alpha1))
			{
				SceneManager.LoadScene(1);
			}
		}
	}
}