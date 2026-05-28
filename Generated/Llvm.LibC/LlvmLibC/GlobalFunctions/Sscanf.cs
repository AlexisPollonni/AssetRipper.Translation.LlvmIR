using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sscanf
{
	[MangledName("sscanf")]
	[DemangledName("sscanf")]
	public unsafe static int Invoke([MangledName("buffer")] void* Buffer, [MangledName("format")] void* Format, ReadOnlySpan<nint> args)
	{
		InlineArray1_Va_list_tag inlineArray1_Va_list_tag = default(InlineArray1_Va_list_tag);
		Internal_ArgList internal_ArgList = default(Internal_ArgList);
		Scanf_core_ReadBuffer scanf_core_ReadBuffer = default(Scanf_core_ReadBuffer);
		Scanf_core_Reader scanf_core_Reader = default(Scanf_core_Reader);
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
			Llvm_lifetime_start_p0.Invoke(24L, &scanf_core_ReadBuffer);
			*(IntPtr*)(&scanf_core_ReadBuffer) = unchecked((nint)(-6148914691236517206L));
			((long*)(&scanf_core_ReadBuffer))[1] = -6148914691236517206L;
			((long*)(&scanf_core_ReadBuffer))[2] = -6148914691236517206L;
			scanf_core_ReadBuffer.Buffer = Buffer;
			scanf_core_ReadBuffer.Buff_len = Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke();
			scanf_core_ReadBuffer.Buff_cur = 0L;
			Llvm_lifetime_start_p0.Invoke(40L, &scanf_core_Reader);
			Llvm_memset_p0_i64.Invoke(&scanf_core_Reader, 0, 40L, isVolatile: false);
			scanf_core_Reader.Rb = (Scanf_core_ReadBuffer*)12297829382473034410uL;
			scanf_core_Reader.Input_stream = (void*)12297829382473034410uL;
			scanf_core_Reader.Stream_getc = (void*)12297829382473034410uL;
			scanf_core_Reader.Stream_ungetc = (void*)12297829382473034410uL;
			scanf_core_Reader.Cur_chars_read = -6148914691236517206L;
			Reader_Constructor.Invoke(&scanf_core_Reader, &scanf_core_ReadBuffer);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Scanf_core_scanf_main.Invoke(&scanf_core_Reader, Format, &internal_ArgList);
			int result = ((num != -1) ? num : (-1));
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(40L, &scanf_core_Reader);
			Llvm_lifetime_end_p0.Invoke(24L, &scanf_core_ReadBuffer);
			ArgList_Destructor.Invoke(&internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_Va_list_tag);
			return result;
		}
	}
}
