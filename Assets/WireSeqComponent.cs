using System;
using UnityEngine;

public sealed class WireSeqComponent : MonoBehaviour
{
	public event Action OnPageLowerEnded;

	// invoked by the PageLower animation
	private void PageLowerEnded()
	{
		OnPageLowerEnded?.Invoke();
	}
}
