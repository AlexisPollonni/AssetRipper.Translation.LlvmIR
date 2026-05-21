using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Snprintf
{
	[MangledName("snprintf")]
	[DemangledName("snprintf")]
	public unsafe static int Invoke([MangledName("buffer")] void* Buffer, [MangledName("buffsz")] long Buffsz, [MangledName("format")] void* Format, ReadOnlySpan<nint> args)
	{
		InlineArray1_Va_list_tag inlineArray1_Va_list_tag = default(InlineArray1_Va_list_tag);
		Llvm_libc_20_1_2_internal_ArgList llvm_libc_20_1_2_internal_ArgList = default(Llvm_libc_20_1_2_internal_ArgList);
		Llvm_libc_20_1_2_printf_core_WriteBuffer llvm_libc_20_1_2_printf_core_WriteBuffer = default(Llvm_libc_20_1_2_printf_core_WriteBuffer);
		Llvm_libc_20_1_2_printf_core_Writer llvm_libc_20_1_2_printf_core_Writer = default(Llvm_libc_20_1_2_printf_core_Writer);
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
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_internal_ArgList);
			Va_list_tag* ptr2 = (Va_list_tag*)(&llvm_libc_20_1_2_internal_ArgList);
			*(int*)ptr2 = -1431655766;
			((int*)ptr2)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr2 + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr2 + 16) = unchecked((nint)(-6148914691236517206L));
			ArgList_Constructor_7zbjxz.Invoke(&llvm_libc_20_1_2_internal_ArgList, (Va_list_tag*)(&inlineArray1_Va_list_tag));
			Llvm_lifetime_start_p0.Invoke(56L, &llvm_libc_20_1_2_printf_core_WriteBuffer);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_WriteBuffer, -86, 56L, isVolatile: false);
			WriteBuffer_Constructor.Invoke(&llvm_libc_20_1_2_printf_core_WriteBuffer, Buffer, ((ulong)Buffsz <= 0uL) ? 0L : (Buffsz - 1L));
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_Writer);
			*(IntPtr*)(&llvm_libc_20_1_2_printf_core_Writer) = unchecked((nint)(-6148914691236517206L));
			((int*)(&llvm_libc_20_1_2_printf_core_Writer))[2] = -1431655766;
			sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_printf_core_Writer) + 12;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			ptr3[3] = -86;
			Writer_Constructor.Invoke(&llvm_libc_20_1_2_printf_core_Writer, &llvm_libc_20_1_2_printf_core_WriteBuffer);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Printf_core_printf_main.Invoke(&llvm_libc_20_1_2_printf_core_Writer, Format, &llvm_libc_20_1_2_internal_ArgList);
			if ((ulong)Buffsz > 0uL)
			{
				((sbyte*)llvm_libc_20_1_2_printf_core_WriteBuffer.Buff)[llvm_libc_20_1_2_printf_core_WriteBuffer.Buff_cur] = 0;
			}
			int result = num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_Writer);
			Llvm_lifetime_end_p0.Invoke(56L, &llvm_libc_20_1_2_printf_core_WriteBuffer);
			ArgList_Destructor.Invoke(&llvm_libc_20_1_2_internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_Va_list_tag);
			return result;
		}
	}
}
