using UnityEngine;

namespace Mono
{
    public class MoveCube : MonoBehaviour
    {
        void Update()
        {
            transform.Rotate(Vector3.left * 100f * Time.deltaTime);
        }
    }
}