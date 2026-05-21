using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_splat_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5splatItEET_h")]
	[DemangledName("unsigned short __llvm_libc_20_1_2_::generic::splat<unsigned short>(unsigned char)")]
	[return: NativeType("unsigned short")]
	public static short Invoke([NativeType("unsigned char")] sbyte value)
	{
		unchecked
		{
			return (short)checked(257 * unchecked((byte)value));
		}
	}
}
