using UnityEngine;
using UnityEngine.UI;

namespace zehreken.i_cheat
{
	public class FpsCounter : MonoBehaviour
	{
		private const int BufferLength = 100;
		private float[] _buffer = new float[BufferLength];
		private int _bufferIndex = 0;
		private float _fps = 0f;
		public Text Text;

		void Update()
		{
			_buffer[_bufferIndex] = Time.deltaTime;
			_bufferIndex++;
			if (_bufferIndex == 100) _bufferIndex = 0;

			float sum = 0f;
			for (var i = 0; i < _buffer.Length; i++)
			{
				sum += _buffer[i];
			}

			float averageTime = sum / BufferLength;
			_fps = 1f / averageTime;
			Text.text = "FPS: " + _fps.ToString("N2");
		}
	}
}