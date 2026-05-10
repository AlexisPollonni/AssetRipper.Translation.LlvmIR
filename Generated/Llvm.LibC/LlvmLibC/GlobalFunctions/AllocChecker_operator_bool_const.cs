using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_12AllocCheckercvbEv")]
[DemangledName("__llvm_libc_20_1_2_::AllocChecker::operator bool() const")]
internal static partial class AllocChecker_operator_bool_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((anon_izyfb7*)@this)->val & 1) == 1;
	}
}
