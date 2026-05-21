using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Endian_1234u_to_big_endian_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal6EndianILj1234EE13to_big_endianIjEET_S4_")]
	[DemangledName("unsigned int __llvm_libc_20_1_2_::internal::Endian<1234u>::to_big_endian<unsigned int>(unsigned int)")]
	[return: NativeType("unsigned int")]
	public static int Invoke([MangledName("v")][NativeType("unsigned int")] int V)
	{
		return Llvm_bswap_i32.Invoke(V);
	}
}
