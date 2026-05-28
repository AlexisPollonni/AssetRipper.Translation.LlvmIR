using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Vsnprintf
{
	[MangledName("vsnprintf")]
	[DemangledName("vsnprintf")]
	public unsafe static int Invoke([MangledName("buffer")] void* Buffer, [MangledName("buffsz")] long Buffsz, [MangledName("format")] void* Format, [MangledName("vlist")] Va_list_tag* Vlist)
	{
		Internal_ArgList internal_ArgList = default(Internal_ArgList);
		Printf_core_WriteBuffer printf_core_WriteBuffer = default(Printf_core_WriteBuffer);
		Printf_core_Writer printf_core_Writer = default(Printf_core_Writer);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(24L, &internal_ArgList);
		unchecked
		{
			Va_list_tag* ptr = (Va_list_tag*)(&internal_ArgList);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
			ArgList_Constructor_7zbjxz.Invoke(&internal_ArgList, Vlist);
			Llvm_lifetime_start_p0.Invoke(56L, &printf_core_WriteBuffer);
			Llvm_memset_p0_i64.Invoke(&printf_core_WriteBuffer, -86, 56L, isVolatile: false);
			WriteBuffer_Constructor.Invoke(&printf_core_WriteBuffer, Buffer, ((ulong)Buffsz <= 0uL) ? 0L : (Buffsz - 1L));
			Llvm_lifetime_start_p0.Invoke(16L, &printf_core_Writer);
			*(IntPtr*)(&printf_core_Writer) = unchecked((nint)(-6148914691236517206L));
			((int*)(&printf_core_Writer))[2] = -1431655766;
			sbyte* ptr2 = (sbyte*)(&printf_core_Writer) + 12;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			Writer_Constructor.Invoke(&printf_core_Writer, &printf_core_WriteBuffer);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Printf_core_printf_main.Invoke(&printf_core_Writer, Format, &internal_ArgList);
			if ((ulong)Buffsz > 0uL)
			{
				((sbyte*)printf_core_WriteBuffer.Buff)[printf_core_WriteBuffer.Buff_cur] = 0;
			}
			int result = num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &printf_core_Writer);
			Llvm_lifetime_end_p0.Invoke(56L, &printf_core_WriteBuffer);
			ArgList_Destructor.Invoke(&internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &internal_ArgList);
			return result;
		}
	}
}
