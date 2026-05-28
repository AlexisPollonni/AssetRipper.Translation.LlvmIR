using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcmp_unsigned_long_loop_and_tail_align_above
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6MemcmpImE25loop_and_tail_align_aboveEmPKNS_3cpp4byteES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memcmp<unsigned long>::loop_and_tail_align_above(unsigned long, __llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static int Invoke([MangledName("threshold")][NativeType("unsigned long")] long Threshold, [MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* P2, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		void* ptr = null;
		void* p = null;
		long num = 0L;
		Fputil_internal_FPStorage_v3nexn fputil_internal_FPStorage_v3nexn = default(Fputil_internal_FPStorage_v3nexn);
		ptr = P1;
		p = P2;
		num = Count;
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_internal_FPStorage_v3nexn);
		unchecked
		{
			*(long*)(&fputil_internal_FPStorage_v3nexn) = -6148914691236517206L;
			AlignHelper_8ul_Constructor.Invoke(&fputil_internal_FPStorage_v3nexn, ptr);
			if (Details_expects_bool_condition_bool.Invoke((ulong)num >= (ulong)Threshold, Expected: false) && AlignHelper_8ul_not_aligned.Invoke(&fputil_internal_FPStorage_v3nexn))
			{
				*(int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt) = -1431655766;
				fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Memcmp_unsigned_long_block.Invoke(ptr, p);
				if (StrictIntegralType_int_ToBoolean.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt))
				{
					goto IL_00bd;
				}
				Adjust_cpp_byte_const_cpp_byte_const.Invoke(fputil_internal_FPStorage_v3nexn.Val, &ptr, &p, &num);
			}
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0 = Memcmp_unsigned_long_loop_and_tail.Invoke(ptr, p, num);
			goto IL_00bd;
		}
		IL_00bd:
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_internal_FPStorage_v3nexn);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0;
	}
}
