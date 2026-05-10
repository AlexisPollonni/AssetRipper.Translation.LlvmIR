using LlvmLibC.Helpers;

namespace LlvmLibC.Enumerations;

[MangledName("_ZTSSt18float_denorm_style")]
[DemangledName("std::float_denorm_style")]
public enum float_denorm_style
{
	denorm_indeterminate = -1,
	denorm_absent,
	denorm_present
}
