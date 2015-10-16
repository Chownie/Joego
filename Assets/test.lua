function MoveForward(amount)  -- Simple function to call the function inside LuaBinding.cs to out a message
	luabinding:MoveForwardCS(amount)
end

function MoveBackward(amount)  -- Simple function to call the function inside LuaBinding.cs to out a message
	luabinding:MoveBackwardCS(amount)
end

luabinding:BindMessageFunction(MoveForward) -- Tell LuaBinding.cs to bind the WriteFromLua function to its LuaFunction variable

luabinding:BindMessageFunction(MoveBackward)

MoveForward(1)
MoveForward(1)
MoveForward(1)
MoveForward(1)
MoveForward(1)