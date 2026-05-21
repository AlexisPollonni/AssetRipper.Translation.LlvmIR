using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Endian_1234u_to_big_endian_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal6EndianILj1234EE13to_big_endianItEET_S4_")]
	[DemangledName("unsigned short __llvm_libc_20_1_2_::internal::Endian<1234u>::to_big_endian<unsigned short>(unsigned short)")]
	[return: NativeType("unsigned short")]
	public static short Invoke([MangledName("v")][NativeType("unsigned short")] short V)
	{
		return Llvm_bswap_i16.Invoke(V);
	}
}
