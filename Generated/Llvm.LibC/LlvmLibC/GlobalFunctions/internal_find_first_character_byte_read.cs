using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_find_first_character_byte_read
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal30find_first_character_byte_readEPKhhm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::find_first_character_byte_read(unsigned char const*, unsigned char, unsigned long)")]
	public unsafe static void* Invoke([NativeType("unsigned char const*")] void* src, [NativeType("unsigned char")] sbyte ch, [NativeType("unsigned long")] long n)
	{
		void* ptr = src;
		sbyte b = ch;
		long num = n;
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
