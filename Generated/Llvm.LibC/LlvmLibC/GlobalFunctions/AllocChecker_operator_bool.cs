using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12AllocCheckeraSEb")]
[DemangledName("__llvm_libc_20_1_2_::AllocChecker::operator=(bool)")]
internal static partial class AllocChecker_operator_bool
{
	public unsafe static void* Invoke(void* @this, bool status)
	{
		sbyte b = (status ? ((sbyte)1) : ((sbyte)0));
		unchecked((anon_izyfb7*)@this)->val = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		return @this;
	}
}
