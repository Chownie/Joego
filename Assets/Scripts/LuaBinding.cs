using UnityEngine;
using System.Collections;
using LuaInterface; //Reference the LuaInterface DLL

public class LuaBinding {
	public Transform player = GameObject.FindWithTag("Player").transform;
	//Reference to bound Lua function set within Lua
	public LuaFunction boundMessageFunction;
	public void BindMessageFunction(LuaFunction func){
		//Binding
		boundMessageFunction = func;	
	}
	public void MessageFromLua(string message){
		//Output message into the debug log
		player.position = new Vector3(1f, 0f, 0f);
	}
	public void MessageToLua(){
		//Call the bound function with a string as its first param
		boundMessageFunction.Call("Hello");
	}
}