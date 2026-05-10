using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4BcmpImE25loop_and_tail_align_aboveEmPKNS_3cpp4byteES6_m")]
[DemangledName("__llvm_libc_20_1_2_::generic::Bcmp<unsigned long>::loop_and_tail_align_above(unsigned long, __llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class generic_Bcmp_unsigned_long_loop_and_tail_align_above_unsigned_long_cpp_byte_const_cpp_byte_const_unsigned_long
{
	public unsafe static int Invoke(long threshold, void* p1, void* p2, long count)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		void* ptr = null;
		void* p3 = null;
		long num = 0L;
		fputil_internal_FPStorage_v3nexn fputil_internal_FPStorage_v3nexn2 = default(fputil_internal_FPStorage_v3nexn);
		ptr = p1;
		p3 = p2;
		num = count;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_internal_FPStorage_v3nexn2);
		unchecked
		{
			*(long*)(&fputil_internal_FPStorage_v3nexn2) = -6148914691236517206L;
			AlignHelper_8ul_AlignHelper_cpp_byte_const.Invoke(&fputil_internal_FPStorage_v3nexn2, ptr);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ulong)num >= (ulong)threshold, expected: false) && AlignHelper_8ul_not_aligned_const.Invoke(&fputil_internal_FPStorage_v3nexn2))
			{
				*(int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2) = -1431655766;
				fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Bcmp_unsigned_long_block_cpp_byte_const_cpp_byte_const.Invoke(ptr, p3);
				if (StrictIntegralType_unsigned_int_operator_bool_const.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2))
				{
					goto IL_00bd;
				}
				void_adjust_cpp_byte_const_cpp_byte_const_long_cpp_byte_const_restrict_cpp_byte_const_restrict_unsigned_long.Invoke(fputil_internal_FPStorage_v3nexn2.val, &ptr, &p3, &num);
			}
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Bcmp_unsigned_long_loop_and_tail_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(ptr, p3, num);
			goto IL_00bd;
		}
		IL_00bd:
		llvm_lifetime_end_p0.Invoke(8L, &fputil_internal_FPStorage_v3nexn2);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
