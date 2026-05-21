using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_swap
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize4swapEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::swap(unsigned long, unsigned long) const")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("i")][NativeType("unsigned long")] long I, [MangledName("j")][NativeType("unsigned long")] long J)
	{
		long num = 0L;
		InlineArray4_SByte inlineArray4_SByte = default(InlineArray4_SByte);
		void* ptr = null;
		void* ptr2 = null;
		long num2 = 0L;
		void* ptr3 = null;
		long num3 = 0L;
		sbyte b = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 4L;
		Llvm_lifetime_start_p0.Invoke(4L, &inlineArray4_SByte);
		unchecked
		{
			*(sbyte*)(&inlineArray4_SByte) = -86;
			((sbyte*)(&inlineArray4_SByte))[1] = -86;
			((sbyte*)(&inlineArray4_SByte))[2] = -86;
			((sbyte*)(&inlineArray4_SByte))[3] = -86;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = ArrayGenericSize_get_internal.Invoke(This, I);
			Llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = ArrayGenericSize_get_internal.Invoke(This, J);
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = (long)((ulong)((Llvm_libc_20_1_2_scanf_core_ReadBuffer*)This)->Buff_cur % 4uL);
			Llvm_lifetime_start_p0.Invoke(8L, &ptr3);
			ptr3 = (byte*)ptr + (((Llvm_libc_20_1_2_scanf_core_ReadBuffer*)This)->Buff_cur - num2);
			while (ptr != ptr3)
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray4_SByte, ptr, 4L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(ptr, ptr2, 4L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(ptr2, &inlineArray4_SByte, 4L, isVolatile: false);
				ptr = (byte*)ptr + 4;
				ptr2 = (byte*)ptr2 + 4;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			for (num3 = 0L; (ulong)num3 < (ulong)num2; num3++)
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = ((sbyte*)ptr)[num3];
				sbyte b2 = ((sbyte*)ptr2)[num3];
				((sbyte*)ptr)[num3] = b2;
				((sbyte*)ptr2)[num3] = b;
				Llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			Llvm_lifetime_end_p0.Invoke(4L, &inlineArray4_SByte);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
