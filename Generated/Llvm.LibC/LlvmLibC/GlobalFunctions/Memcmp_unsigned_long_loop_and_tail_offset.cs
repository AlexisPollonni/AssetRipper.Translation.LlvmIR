using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcmp_unsigned_long_loop_and_tail_offset
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpImE20loop_and_tail_offsetEPKNS_3cpp4byteES6_mm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned long>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long, unsigned long)")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* p2, [NativeType("unsigned long")] long count, [NativeType("unsigned long")] long offset)
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
					if (!generic_eq_unsigned_long.Invoke(p1, p2, num2))
					{
						fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = generic_cmp_neq_unsigned_long.Invoke(p1, p2, num2);
						break;
					}
					num2 += 8L;
					continue;
				}
				fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0 = Memcmp_unsigned_long_block_offset.Invoke(p1, p2, num);
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
		}
	}
}
