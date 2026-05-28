using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bcmp_unsigned_char_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4BcmpIhE5blockEPKNS_3cpp4byteES6_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Bcmp<unsigned char>::block(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, Generic_neq_unsigned_char.Invoke(P1, P2, 0L));
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
