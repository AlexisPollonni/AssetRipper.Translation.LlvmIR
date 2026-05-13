using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpImE20loop_and_tail_offsetEPKNS_3cpp4byteES6_mm")]
[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned long>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long, unsigned long)")]
internal static partial class generic_Memcmp_unsigned_long_loop_and_tail_offset_cpp_byte_const_cpp_byte_const_unsigned_long_unsigned_long
{
	public unsafe static int Invoke(void* p1, void* p2, long count, long offset)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long num = 0L;
		long num2 = offset;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = count - 8L;
			while (true)
			{
				if ((ulong)num2 < (ulong)num)
				{
					if (!bool_generic_eq_unsigned_long_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, num2))
					{
						fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = StrictIntegralType_int_generic_cmp_neq_unsigned_long_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, num2);
						break;
					}
					num2 += 8L;
					continue;
				}
				fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Memcmp_unsigned_long_block_offset_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, num);
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
		}
	}
}
