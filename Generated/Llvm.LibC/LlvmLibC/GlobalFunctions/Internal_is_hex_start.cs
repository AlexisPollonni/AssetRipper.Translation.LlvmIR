using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_is_hex_start
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal12is_hex_startEPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::is_hex_start(char const*, unsigned long)")]
	public unsafe static bool Invoke([MangledName("src")][NativeType("char const*")] void* Src, [MangledName("src_len")][NativeType("unsigned long")] long Src_len)
	{
		unchecked
		{
			if ((ulong)Src_len < 3uL)
			{
				return false;
			}
			return *(sbyte*)Src == 48 && Internal_tolower_hsks5s.Invoke(((sbyte*)Src)[1]) == 120 && Internal_isalnum_r2dwwj.Invoke(((sbyte*)Src)[2]) && Internal_b36_char_to_int_cwm4z4.Invoke(((sbyte*)Src)[2]) < 16;
		}
	}
}
