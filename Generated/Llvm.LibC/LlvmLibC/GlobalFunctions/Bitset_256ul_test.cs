using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bitset_256ul_test
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp6bitsetILm256EE4testEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::test(unsigned long) const")]
	public unsafe static bool Invoke([MangledName("this")] void* This, [NativeType("unsigned long")] long Index)
	{
		return (unchecked(((long*)(&((Cpp_array_jgy3xh*)This)->Data))[(ulong)Index / 64uL]) & Bitset_256ul_mask.Invoke(Index)) != 0L;
	}
}
