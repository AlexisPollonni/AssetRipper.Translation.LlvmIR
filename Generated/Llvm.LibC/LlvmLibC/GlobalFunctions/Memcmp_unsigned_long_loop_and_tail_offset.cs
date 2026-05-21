using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcmp_unsigned_long_loop_and_tail_offset
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpImE20loop_and_tail_offsetEPKNS_3cpp4byteES6_mm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned long>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long, unsigned long)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("count")][NativeType("unsigned long")] long Count, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long num = 0L;
		long num2 = Offset;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Count - 8L;
			while (true)
			{
				if ((ulong)num2 < (ulong)num)
				{
					if (!Generic_eq_unsigned_long.Invoke(P1, P2, num2))
					{
						llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Generic_cmp_neq_unsigned_long.Invoke(P1, P2, num2);
						break;
					}
					num2 += 8L;
					continue;
				}
				llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Memcmp_unsigned_long_block_offset.Invoke(P1, P2, num);
				break;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
		}
	}
}
