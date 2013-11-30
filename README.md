Lua Lexer
=========

An Lua Lexer written in C# designed for analysing but not interpreting Lua, also includes supports for lexing the != operator and C-like comment syntax.

Performance
=========

While primarily unfinished, the lexer can process the following code 1,000,000 times in 13ms:

```lua
-- globals.lua
-- show all global variables

local seen={}

function dump(t,i)
	seen[t]=true
	local s={}
	local n=0
	for k in pairs(t) do
		n=n+1 s[n]=k
	end
	table.sort(s)
	for k,v in ipairs(s) do
		print(i,v)
		v=t[v]
		if type(v)=="table" and not seen[v] then
			dump(v,i.."\t")
		end
	end
end

dump(_G,"")
```

Code taken from the Lua Demo at http://www.lua.org/cgi-bin/demo?globals
