using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_4ul_swap
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm4EE4swapEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>::swap(unsigned long, unsigned long) const")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("i")][NativeType("unsigned long")] long I, [MangledName("j")][NativeType("unsigned long")] long J)
	{
		InlineArray4_SByte inlineArray4_SByte = default(InlineArray4_SByte);
		void* ptr = null;
		void* ptr2 = null;
		Llvm_lifetime_start_p0.Invoke(4L, &inlineArray4_SByte);
		unchecked
		{
			*(sbyte*)(&inlineArray4_SByte) = -86;
			((sbyte*)(&inlineArray4_SByte))[1] = -86;
			((sbyte*)(&inlineArray4_SByte))[2] = -86;
			((sbyte*)(&inlineArray4_SByte))[3] = -86;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = ArrayFixedSize_4ul_get_internal.Invoke(This, I);
			Llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = ArrayFixedSize_4ul_get_internal.Invoke(This, J);
			Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray4_SByte, ptr, 4L, isVolatile: false);
			Llvm_memmove_p0_p0_i64.Invoke(ptr, ptr2, 4L, isVolatile: false);
			Llvm_memcpy_p0_p0_i64.Invoke(ptr2, &inlineArray4_SByte, 4L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			Llvm_lifetime_end_p0.Invoke(4L, &inlineArray4_SByte);
		}
	}
}
