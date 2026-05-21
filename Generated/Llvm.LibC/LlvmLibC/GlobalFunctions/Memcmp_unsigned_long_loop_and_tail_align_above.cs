using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcmp_unsigned_long_loop_and_tail_align_above
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpImE25loop_and_tail_align_aboveEmPKNS_3cpp4byteES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned long>::loop_and_tail_align_above(unsigned long, __llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static int Invoke([NativeType("unsigned long")] long threshold, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long count)
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
			AlignHelper_8ul_Constructor.Invoke(&fputil_internal_FPStorage_v3nexn2, ptr);
			if (details_expects_bool_condition_bool.Invoke((ulong)num >= (ulong)threshold, expected: false) && AlignHelper_8ul_not_aligned.Invoke(&fputil_internal_FPStorage_v3nexn2))
			{
				*(int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2) = -1431655766;
				fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = Memcmp_unsigned_long_block.Invoke(ptr, p3);
				if (StrictIntegralType_int_ToBoolean.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2))
				{
					goto IL_00bd;
				}
				adjust_cpp_byte_const_cpp_byte_const.Invoke(fputil_internal_FPStorage_v3nexn2.val, &ptr, &p3, &num);
			}
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = Memcmp_unsigned_long_loop_and_tail.Invoke(ptr, p3, num);
			goto IL_00bd;
		}
		IL_00bd:
		llvm_lifetime_end_p0.Invoke(8L, &fputil_internal_FPStorage_v3nexn2);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
