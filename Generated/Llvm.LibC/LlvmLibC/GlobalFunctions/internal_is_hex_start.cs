using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_is_hex_start
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal12is_hex_startEPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::is_hex_start(char const*, unsigned long)")]
	public unsafe static bool Invoke([NativeType("char const*")] void* src, [NativeType("unsigned long")] long src_len)
	{
		unchecked
		{
			if ((ulong)src_len < 3uL)
			{
				return false;
			}
			return *(sbyte*)src == 48 && internal_tolower_hsks5s.Invoke(((sbyte*)src)[1]) == 120 && internal_isalnum_r2dwwj.Invoke(((sbyte*)src)[2]) && internal_b36_char_to_int_cwm4z4.Invoke(((sbyte*)src)[2]) < 16;
		}
	}
}
