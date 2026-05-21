using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Endian_1234u_to_big_endian_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal6EndianILj1234EE13to_big_endianImEET_S4_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::Endian<1234u>::to_big_endian<unsigned long>(unsigned long)")]
	[return: NativeType("unsigned long")]
	public static long Invoke([MangledName("v")][NativeType("unsigned long")] long V)
	{
		return Llvm_bswap_i64.Invoke(V);
	}
}
