using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcmp_unsigned_short_block_offset
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpItE12block_offsetEPKNS_3cpp4byteES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned short>::block_offset(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = new Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = Generic_cmp_unsigned_short.Invoke(P1, P2, Offset)
		};
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
