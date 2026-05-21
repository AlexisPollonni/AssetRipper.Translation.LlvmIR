using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_splat_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5splatImEET_h")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::generic::splat<unsigned long>(unsigned char)")]
	[return: NativeType("unsigned long")]
	public static long Invoke([MangledName("value")][NativeType("unsigned char")] sbyte Value)
	{
		return unchecked(72340172838076673L * (byte)Value);
	}
}
