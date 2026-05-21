using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bitset_256ul_set
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EE3setEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::set(unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [NativeType("unsigned long")] long Index)
	{
		long num = Bitset_256ul_mask.Invoke(Index);
		unchecked(((long*)(&((Llvm_libc_20_1_2_cpp_array_jgy3xh*)This)->Data))[(ulong)Index / 64uL]) |= num;
	}
}
