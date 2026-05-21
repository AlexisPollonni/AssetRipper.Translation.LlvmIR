using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_cmp_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic3cmpIjEENS_18StrictIntegralTypeIiEEPKNS_3cpp4byteES7_m")]
	[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<int> __llvm_libc_20_1_2_::generic::cmp<unsigned int>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrictIntegralType<int>")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long offset)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		int a = 0;
		int b = 0;
		llvm_lifetime_start_p0.Invoke(4L, &a);
		a = generic_load_be_unsigned_int.Invoke(p1, offset);
		llvm_lifetime_start_p0.Invoke(4L, &b);
		b = generic_load_be_unsigned_int.Invoke(p2, offset);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = cmp_uint32_t.Invoke(a, b);
		llvm_lifetime_end_p0.Invoke(4L, &b);
		llvm_lifetime_end_p0.Invoke(4L, &a);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
