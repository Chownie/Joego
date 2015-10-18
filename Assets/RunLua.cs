using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RunLua : MonoBehaviour {
	public InputField input;
	public LuaManager lua;
	// Use this for initialization
	
	public void onClick() {
		if(input.text == "") {
			return;	
		}
		
		lua.Run(input.text);
		input.text = "";
	}
}