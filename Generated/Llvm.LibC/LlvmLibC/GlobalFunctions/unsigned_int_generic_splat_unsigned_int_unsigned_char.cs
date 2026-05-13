using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5splatIjEET_h")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::splat<unsigned int>(unsigned char)")]
internal static partial class unsigned_int_generic_splat_unsigned_int_unsigned_char
{
	public static int Invoke(sbyte value)
	{
		return unchecked(16843009 * (byte)value);
	}
}
