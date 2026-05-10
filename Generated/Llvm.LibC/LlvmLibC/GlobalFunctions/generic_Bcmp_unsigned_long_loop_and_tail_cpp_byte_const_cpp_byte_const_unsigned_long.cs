using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4BcmpImE13loop_and_tailEPKNS_3cpp4byteES6_m")]
[DemangledName("__llvm_libc_20_1_2_::generic::Bcmp<unsigned long>::loop_and_tail(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class generic_Bcmp_unsigned_long_loop_and_tail_cpp_byte_const_cpp_byte_const_unsigned_long
{
	public unsafe static int Invoke(void* p1, void* p2, long count)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = generic_Bcmp_unsigned_long_loop_and_tail_offset_cpp_byte_const_cpp_byte_const_unsigned_long_unsigned_long.Invoke(p1, p2, count, 0L)
		};
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
