using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_find_first_character
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20find_first_characterEPKhhm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::find_first_character(unsigned char const*, unsigned char, unsigned long)")]
	public unsafe static void* Invoke([MangledName("src")][NativeType("unsigned char const*")] void* Src, [MangledName("ch")][NativeType("unsigned char")] sbyte Ch, [MangledName("max_strlen")][NativeType("unsigned long")] long Max_strlen)
	{
		return Internal_find_first_character_byte_read.Invoke(Src, Ch, Max_strlen);
	}
}
