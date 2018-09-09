using UnityEngine;
using UnityEngine.UI;

namespace zehreken.i_cheat
{
	public class FpsCounter : MonoBehaviour
	{
		private const int BufferLength = 100;
		private readonly float[] _buffer = new float[BufferLength];
		private int _bufferIndex = 0;
		public float _deltaTime = 0f;
		public Text Text;

		void Update()
		{
			// This is just for preventing the fluctuation, _deltaTime = Time.deltaTime is also fine
			_deltaTime += (Time.deltaTime - _deltaTime) * 0.1f;
			float miliseconds = _deltaTime * 1000f;
			
			var fps = 1 / _deltaTime;
			
			_buffer[_bufferIndex] = fps;
			_bufferIndex++;
			if (_bufferIndex == 100) _bufferIndex = 0;

			float sum = 0f;
			for (var i = 0; i < _buffer.Length; i++)
			{
				sum += _buffer[i];
			}

			float averageFps = sum / BufferLength;
			Text.text = string.Format("{0:0.0} ms ({1:0.} fps) ({2:0.0} average fps)", miliseconds,  fps, averageFps);
		}
	}
}