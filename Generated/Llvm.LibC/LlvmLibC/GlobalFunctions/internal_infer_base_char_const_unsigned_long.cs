using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal10infer_baseEPKcm")]
[DemangledName("__llvm_libc_20_1_2_::internal::infer_base(char const*, unsigned long)")]
internal static partial class internal_infer_base_char_const_unsigned_long
{
	public unsafe static int Invoke(void* src, long src_len)
	{
		if (internal_is_hex_start_char_const_unsigned_long.Invoke(src, src_len))
		{
			return 16;
		}
		if (unchecked((ulong)src_len > 0uL && *(sbyte*)src == 48))
		{
			return 8;
		}
		return 10;
	}
}
