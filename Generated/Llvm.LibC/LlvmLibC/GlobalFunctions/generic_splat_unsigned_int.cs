using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_splat_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5splatIjEET_h")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::splat<unsigned int>(unsigned char)")]
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned char")] sbyte value)
	{
		return unchecked(16843009 * (byte)value);
	}
}
