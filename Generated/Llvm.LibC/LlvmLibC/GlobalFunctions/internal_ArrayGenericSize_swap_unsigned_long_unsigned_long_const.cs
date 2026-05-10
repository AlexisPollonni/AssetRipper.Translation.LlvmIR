using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize4swapEmm")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::swap(unsigned long, unsigned long) const")]
internal static partial class internal_ArrayGenericSize_swap_unsigned_long_unsigned_long_const
{
	public unsafe static void Invoke(void* @this, long i, long j)
	{
		long num = 0L;
		InlineArray4_SByte inlineArray4_SByte = default(InlineArray4_SByte);
		void* ptr = null;
		void* ptr2 = null;
		long num2 = 0L;
		void* ptr3 = null;
		long num3 = 0L;
		sbyte b = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 4L;
		llvm_lifetime_start_p0.Invoke(4L, &inlineArray4_SByte);
		unchecked
		{
			*(sbyte*)(&inlineArray4_SByte) = -86;
			((sbyte*)(&inlineArray4_SByte))[1] = -86;
			((sbyte*)(&inlineArray4_SByte))[2] = -86;
			((sbyte*)(&inlineArray4_SByte))[3] = -86;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = internal_ArrayGenericSize_get_internal_unsigned_long_const.Invoke(@this, i);
			llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = internal_ArrayGenericSize_get_internal_unsigned_long_const.Invoke(@this, j);
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = (long)((ulong)((scanf_core_ReadBuffer*)@this)->buff_cur % 4uL);
			llvm_lifetime_start_p0.Invoke(8L, &ptr3);
			ptr3 = (byte*)ptr + (((scanf_core_ReadBuffer*)@this)->buff_cur - num2);
			while (ptr != ptr3)
			{
				llvm_memcpy_p0_p0_i64.Invoke(&inlineArray4_SByte, ptr, 4L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(ptr, ptr2, 4L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(ptr2, &inlineArray4_SByte, 4L, isVolatile: false);
				ptr = (byte*)ptr + 4;
				ptr2 = (byte*)ptr2 + 4;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			for (num3 = 0L; (ulong)num3 < (ulong)num2; num3++)
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = ((sbyte*)ptr)[num3];
				sbyte b2 = ((sbyte*)ptr2)[num3];
				((sbyte*)ptr)[num3] = b2;
				((sbyte*)ptr2)[num3] = b;
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &ptr3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			llvm_lifetime_end_p0.Invoke(4L, &inlineArray4_SByte);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
