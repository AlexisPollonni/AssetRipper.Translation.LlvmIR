using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcmp_unsigned_long_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpImE5blockEPKNS_3cpp4byteES6_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned long>::block(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = new Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = Memcmp_unsigned_long_block_offset.Invoke(P1, P2, 0L)
		};
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
