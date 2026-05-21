using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_splat_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5splatIhEET_h")]
	[DemangledName("unsigned char __llvm_libc_20_1_2_::generic::splat<unsigned char>(unsigned char)")]
	[return: NativeType("unsigned char")]
	public static sbyte Invoke([NativeType("unsigned char")] sbyte value)
	{
		unchecked
		{
			return (sbyte)checked(1 * unchecked((byte)value));
		}
	}
}
