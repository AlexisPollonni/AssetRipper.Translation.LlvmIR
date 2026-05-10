using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm4EE4swapEmm")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>::swap(unsigned long, unsigned long) const")]
internal static partial class internal_ArrayFixedSize_4ul_swap_unsigned_long_unsigned_long_const
{
	public unsafe static void Invoke(void* @this, long i, long j)
	{
		InlineArray4_SByte inlineArray4_SByte = default(InlineArray4_SByte);
		void* ptr = null;
		void* ptr2 = null;
		llvm_lifetime_start_p0.Invoke(4L, &inlineArray4_SByte);
		unchecked
		{
			*(sbyte*)(&inlineArray4_SByte) = -86;
			((sbyte*)(&inlineArray4_SByte))[1] = -86;
			((sbyte*)(&inlineArray4_SByte))[2] = -86;
			((sbyte*)(&inlineArray4_SByte))[3] = -86;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = internal_ArrayFixedSize_4ul_get_internal_unsigned_long_const.Invoke(@this, i);
			llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = internal_ArrayFixedSize_4ul_get_internal_unsigned_long_const.Invoke(@this, j);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray4_SByte, ptr, 4L, isVolatile: false);
			llvm_memmove_p0_p0_i64.Invoke(ptr, ptr2, 4L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(ptr2, &inlineArray4_SByte, 4L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			llvm_lifetime_end_p0.Invoke(4L, &inlineArray4_SByte);
		}
	}
}
