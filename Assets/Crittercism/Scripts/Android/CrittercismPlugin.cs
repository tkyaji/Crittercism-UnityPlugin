#if UNITY_ANDROID && !UNITY_EDITOR

using UnityEngine;

public class CrittercismPlugin {

	private static AndroidJavaObject currentActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
	private static AndroidJavaClass crittercismPluginClass = new AndroidJavaClass("jp.co.magicant.crittercism.CrittercismPlugin");

	public static void Initialize(string appId) {
		crittercismPluginClass.CallStatic("initialize", currentActivity, appId);
	}
}

#endif
