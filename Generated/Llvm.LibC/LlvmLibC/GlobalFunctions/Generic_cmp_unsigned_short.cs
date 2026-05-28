using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_cmp_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic3cmpItEENS_18StrictIntegralTypeIiEEPKNS_3cpp4byteES7_m")]
	[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<int> __llvm_libc_20_1_2_::generic::cmp<unsigned short>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrictIntegralType<int>")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		StrictIntegralType_int_StrictIntegralType_int_false.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, unchecked((ushort)Generic_load_be_unsigned_short.Invoke(P1, Offset)) - unchecked((ushort)Generic_load_be_unsigned_short.Invoke(P2, Offset)));
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
