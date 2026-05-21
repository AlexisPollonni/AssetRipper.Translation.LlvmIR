using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_16ul_swap
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm16EE4swapEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>::swap(unsigned long, unsigned long) const")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned long")] long i, [NativeType("unsigned long")] long j)
	{
		InlineArray16_SByte inlineArray16_SByte = default(InlineArray16_SByte);
		void* ptr = null;
		void* ptr2 = null;
		llvm_lifetime_start_p0.Invoke(16L, &inlineArray16_SByte);
		unchecked
		{
			*(sbyte*)(&inlineArray16_SByte) = -86;
			((sbyte*)(&inlineArray16_SByte))[1] = -86;
			((sbyte*)(&inlineArray16_SByte))[2] = -86;
			((sbyte*)(&inlineArray16_SByte))[3] = -86;
			((sbyte*)(&inlineArray16_SByte))[4] = -86;
			((sbyte*)(&inlineArray16_SByte))[5] = -86;
			((sbyte*)(&inlineArray16_SByte))[6] = -86;
			((sbyte*)(&inlineArray16_SByte))[7] = -86;
			((sbyte*)(&inlineArray16_SByte))[8] = -86;
			((sbyte*)(&inlineArray16_SByte))[9] = -86;
			((sbyte*)(&inlineArray16_SByte))[10] = -86;
			((sbyte*)(&inlineArray16_SByte))[11] = -86;
			((sbyte*)(&inlineArray16_SByte))[12] = -86;
			((sbyte*)(&inlineArray16_SByte))[13] = -86;
			((sbyte*)(&inlineArray16_SByte))[14] = -86;
			((sbyte*)(&inlineArray16_SByte))[15] = -86;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = ArrayFixedSize_16ul_get_internal.Invoke(@this, i);
			llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = ArrayFixedSize_16ul_get_internal.Invoke(@this, j);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray16_SByte, ptr, 16L, isVolatile: false);
			llvm_memmove_p0_p0_i64.Invoke(ptr, ptr2, 16L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(ptr2, &inlineArray16_SByte, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			llvm_lifetime_end_p0.Invoke(16L, &inlineArray16_SByte);
		}
	}
}
