using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic4BcmpImE20loop_and_tail_offsetEPKNS_3cpp4byteES6_mm")]
[DemangledName("__llvm_libc_20_1_2_::generic::Bcmp<unsigned long>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long, unsigned long)")]
internal static partial class generic_Bcmp_unsigned_long_loop_and_tail_offset_cpp_byte_const_cpp_byte_const_unsigned_long_unsigned_long
{
	public unsafe static int Invoke(void* p1, void* p2, long count, long offset)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long num = 0L;
		int num2 = 0;
		long num3 = offset;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = count - 8L;
			while (true)
			{
				if ((ulong)num3 < (ulong)num)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = unsigned_int_generic_neq_unsigned_long_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, num3);
					int num4;
					if (num2 != 0)
					{
						StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false_unsigned_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, num2);
						num4 = 1;
					}
					else
					{
						num4 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num2);
					switch (num4)
					{
					case 0:
						goto IL_009c;
					}
				}
				else
				{
					fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_Bcmp_unsigned_long_tail_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, count);
				}
				break;
				IL_009c:
				num3 += 8L;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
		}
	}
}
