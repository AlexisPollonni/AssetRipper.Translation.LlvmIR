using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bcmp_unsigned_long_loop_and_tail
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4BcmpImE13loop_and_tailEPKNS_3cpp4byteES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Bcmp<unsigned long>::loop_and_tail(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = new Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = Bcmp_unsigned_long_loop_and_tail_offset.Invoke(P1, P2, Count, 0L)
		};
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
