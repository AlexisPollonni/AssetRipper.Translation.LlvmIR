using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bcmp_unsigned_long_loop_and_tail_offset
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4BcmpImE20loop_and_tail_offsetEPKNS_3cpp4byteES6_mm")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Bcmp<unsigned long>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long, unsigned long)")]
	public unsafe static int Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("count")][NativeType("unsigned long")] long Count, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long num = 0L;
		int num2 = 0;
		long num3 = Offset;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = Count - 8L;
			while (true)
			{
				if ((ulong)num3 < (ulong)num)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = Generic_neq_unsigned_long.Invoke(P1, P2, num3);
					int num4;
					if (num2 != 0)
					{
						StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, num2);
						num4 = 1;
					}
					else
					{
						num4 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
					switch (num4)
					{
					case 0:
						goto IL_009c;
					}
				}
				else
				{
					llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Bcmp_unsigned_long_tail.Invoke(P1, P2, Count);
				}
				break;
				IL_009c:
				num3 += 8L;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
		}
	}
}
