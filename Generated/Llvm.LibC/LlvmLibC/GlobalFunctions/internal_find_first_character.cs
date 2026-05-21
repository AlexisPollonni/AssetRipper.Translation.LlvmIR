using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_find_first_character
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20find_first_characterEPKhhm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::find_first_character(unsigned char const*, unsigned char, unsigned long)")]
	public unsafe static void* Invoke([NativeType("unsigned char const*")] void* src, [NativeType("unsigned char")] sbyte ch, [NativeType("unsigned long")] long max_strlen)
	{
		return internal_find_first_character_byte_read.Invoke(src, ch, max_strlen);
	}
}
