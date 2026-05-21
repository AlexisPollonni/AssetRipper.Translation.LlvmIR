using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_first_non_whitespace
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20first_non_whitespaceEPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::first_non_whitespace(char const*, unsigned long)")]
	public unsafe static void* Invoke([MangledName("src")][NativeType("char const*")] void* Src, [MangledName("src_len")][NativeType("unsigned long")] long Src_len)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < (ulong)Src_len && Internal_isspace_fna23v.Invoke(((sbyte*)Src)[num]); num++)
			{
			}
			byte* result = (byte*)Src + num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
