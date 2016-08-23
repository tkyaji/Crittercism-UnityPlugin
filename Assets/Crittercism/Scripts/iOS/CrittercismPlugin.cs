#if UNITY_IOS && !UNITY_EDITOR

using System.Runtime.InteropServices;

public class CrittercismPlugin {

	[DllImport("__Internal")]
	private static extern void _CrittercismPlugin_initialize(string appId);

	public static void Initialize(string appId) {
		_CrittercismPlugin_initialize(appId);
	}
}

#endif
