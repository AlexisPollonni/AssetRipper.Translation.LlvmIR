using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5splatIhEET_h")]
[DemangledName("unsigned char __llvm_libc_20_1_2_::generic::splat<unsigned char>(unsigned char)")]
internal static partial class unsigned_char_generic_splat_unsigned_char_unsigned_char
{
	public static sbyte Invoke(sbyte value)
	{
		unchecked
		{
			return (sbyte)checked(1 * unchecked((byte)value));
		}
	}
}
