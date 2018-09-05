using Unity.Mathematics;
using UnityEngine;

namespace Mono
{
	public class MonoStart : MonoBehaviour
	{
		public GameObject Cube;

		void Start()
		{
			for (int i = 0; i < 100; i++)
			{
				for (int j = 0; j < 100; j++)
				{
					Instantiate(Cube, new Vector3(-49.5f + i, -49.5f + j, 0f), Quaternion.identity);
				}
			}
		}
	}
}