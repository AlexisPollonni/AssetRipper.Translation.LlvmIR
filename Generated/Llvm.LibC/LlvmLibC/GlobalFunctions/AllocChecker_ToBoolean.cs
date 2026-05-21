using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AllocChecker_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_12AllocCheckercvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::AllocChecker::operator bool() const")]
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((anon_izyfb7*)@this)->val & 1) == 1;
	}
}
