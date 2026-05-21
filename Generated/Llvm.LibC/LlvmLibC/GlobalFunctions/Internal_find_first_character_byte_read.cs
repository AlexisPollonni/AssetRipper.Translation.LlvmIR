using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_find_first_character_byte_read
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal30find_first_character_byte_readEPKhhm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::find_first_character_byte_read(unsigned char const*, unsigned char, unsigned long)")]
	public unsafe static void* Invoke([MangledName("src")][NativeType("unsigned char const*")] void* Src, [MangledName("ch")][NativeType("unsigned char")] sbyte Ch, [MangledName("n")][NativeType("unsigned long")] long N)
	{
		void* ptr = Src;
		sbyte b = Ch;
		long num = N;
		unchecked
		{
			while (num != 0L && (byte)(*(sbyte*)ptr) != (byte)b)
			{
				num += -1L;
				ptr = (byte*)ptr + 1;
			}
			return (num == 0L) ? null : ptr;
		}
	}
}
