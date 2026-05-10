using LlvmLibC.Helpers;

namespace LlvmLibC.Enumerations;

[MangledName("_ZTS12__rusage_who")]
[DemangledName("__rusage_who")]
public enum rusage_who
{
	RUSAGE_SELF = 0,
	RUSAGE_CHILDREN = -1,
	RUSAGE_THREAD = 1
}
