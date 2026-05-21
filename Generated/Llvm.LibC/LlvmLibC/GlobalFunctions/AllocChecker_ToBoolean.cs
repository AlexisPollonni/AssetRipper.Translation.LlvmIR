using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AllocChecker_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_12AllocCheckercvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::AllocChecker::operator bool() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return (unchecked((Anon_izyfb7*)This)->Val & 1) == 1;
	}
}
