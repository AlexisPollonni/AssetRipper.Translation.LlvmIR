using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EE4flipEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::flip()")]
internal static partial class cpp_bitset_256ul_flip
{
	public unsafe static void Invoke(void* @this)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				long num2 = ((long*)(&((cpp_array_jgy3xh*)@this)->Data))[num] ^ -1L;
				((long*)(&((cpp_array_jgy3xh*)@this)->Data))[num] = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
