using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sprintf
{
	[MangledName("sprintf")]
	[DemangledName("sprintf")]
	public unsafe static int Invoke([MangledName("buffer")] void* Buffer, [MangledName("format")] void* Format, ReadOnlySpan<nint> args)
	{
		InlineArray1_Va_list_tag inlineArray1_Va_list_tag = default(InlineArray1_Va_list_tag);
		Internal_ArgList internal_ArgList = default(Internal_ArgList);
		Printf_core_WriteBuffer printf_core_WriteBuffer = default(Printf_core_WriteBuffer);
		Printf_core_Writer printf_core_Writer = default(Printf_core_Writer);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(24L, &inlineArray1_Va_list_tag);
		unchecked
		{
			Va_list_tag* ptr = (Va_list_tag*)(&inlineArray1_Va_list_tag);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
			InstructionHelper.VAStart((void**)(&inlineArray1_Va_list_tag), args);
			Llvm_lifetime_start_p0.Invoke(24L, &internal_ArgList);
			Va_list_tag* ptr2 = (Va_list_tag*)(&internal_ArgList);
			*(int*)ptr2 = -1431655766;
			((int*)ptr2)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr2 + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr2 + 16) = unchecked((nint)(-6148914691236517206L));
			ArgList_Constructor_7zbjxz.Invoke(&internal_ArgList, (Va_list_tag*)(&inlineArray1_Va_list_tag));
			Llvm_lifetime_start_p0.Invoke(56L, &printf_core_WriteBuffer);
			Llvm_memset_p0_i64.Invoke(&printf_core_WriteBuffer, -86, 56L, isVolatile: false);
			WriteBuffer_Constructor.Invoke(&printf_core_WriteBuffer, Buffer, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
			Llvm_lifetime_start_p0.Invoke(16L, &printf_core_Writer);
			*(IntPtr*)(&printf_core_Writer) = unchecked((nint)(-6148914691236517206L));
			((int*)(&printf_core_Writer))[2] = -1431655766;
			sbyte* ptr3 = (sbyte*)(&printf_core_Writer) + 12;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			ptr3[3] = -86;
			Writer_Constructor.Invoke(&printf_core_Writer, &printf_core_WriteBuffer);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Printf_core_printf_main.Invoke(&printf_core_Writer, Format, &internal_ArgList);
			((sbyte*)printf_core_WriteBuffer.Buff)[printf_core_WriteBuffer.Buff_cur] = 0;
			int result = num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &printf_core_Writer);
			Llvm_lifetime_end_p0.Invoke(56L, &printf_core_WriteBuffer);
			ArgList_Destructor.Invoke(&internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_Va_list_tag);
			return result;
		}
	}
}
