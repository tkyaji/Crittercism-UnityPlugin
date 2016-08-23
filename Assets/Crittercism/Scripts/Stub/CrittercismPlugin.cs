#if (!UNITY_IOS && !UNITY_ANDROID) || UNITY_EDITOR

using UnityEngine;

public class CrittercismPlugin {

	public static void Initialize(string appId) {
		Debug.Log("CrittercismPlugin Initialize : appId=" + appId);
	}
}

#endif
