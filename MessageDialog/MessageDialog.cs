using UnityEngine;
using UnityEngine.UI;

public class MessageDialog : MonoBehaviour
{
	public ScrollRect dialog;

	void Start()
	{
		dialog.verticalNormalizedPosition = 0.0f;
	}
}
