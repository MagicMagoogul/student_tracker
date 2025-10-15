workspace "StudentTracker"
	architecture "x64"
	startproject "StudentTracker"
	
	configurations
	{
		"Debug",
		"Release"
	}
	
outputdir = "%{cfg.buildcfg}-%{cfg.system}-%{cfg.architecture}"

project "StudentTracker"
	location "StudentTracker"
	kind "ConsoleApp"
	language "C#"
	
	-- targetdir ("bin/" .. outputdir .. "/%{prj.name}")
	-- objdir ("bin-int/" .. outputdir .. "/%{prj.name}")
	
	files
	{
		"src/**.cs"
	}
	
	filter "configurations:Debug"
		runtime "Debug"
		symbols "on"

	filter "configurations:Release"
		runtime "Release"
		optimize "on"
