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
	
	public void MoveForwardCS(int amount){
		player.position += player.forward * amount;
	}
	
	public void MoveBackwardCS(int amount){
		player.position -= player.forward * amount;
	}
	
	public void RotateCS(int amount){
		player.Rotate(Vector3.up * amount);
	}
	
	public void MessageToLua(){
		//Call the bound function with a string as its first param
		boundMessageFunction.Call("Hello");
	}
}