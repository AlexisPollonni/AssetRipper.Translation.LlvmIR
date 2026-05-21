using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bitset_256ul_flip
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EE4flipEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::flip()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				long num2 = ((long*)(&((Llvm_libc_20_1_2_cpp_array_jgy3xh*)This)->Data))[num] ^ -1L;
				((long*)(&((Llvm_libc_20_1_2_cpp_array_jgy3xh*)This)->Data))[num] = num2;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
