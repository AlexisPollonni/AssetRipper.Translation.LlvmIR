using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5splatItEET_h")]
[DemangledName("unsigned short __llvm_libc_20_1_2_::generic::splat<unsigned short>(unsigned char)")]
internal static partial class unsigned_short_generic_splat_unsigned_short_unsigned_char
{
	public static short Invoke(sbyte value)
	{
		unchecked
		{
			return (short)checked(257 * unchecked((byte)value));
		}
	}
}
