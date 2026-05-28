using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fscanf
{
	[MangledName("fscanf")]
	[DemangledName("fscanf")]
	public unsafe static int Invoke([MangledName("stream")] void* Stream, [MangledName("format")] void* Format, ReadOnlySpan<nint> args)
	{
		InlineArray1_Va_list_tag inlineArray1_Va_list_tag = default(InlineArray1_Va_list_tag);
		Internal_ArgList internal_ArgList = default(Internal_ArgList);
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
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Scanf_core_vfscanf_internal.Invoke(Stream, Format, &internal_ArgList);
			int result = ((num != -1) ? num : (-1));
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			ArgList_Destructor.Invoke(&internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_Va_list_tag);
			return result;
		}
	}
}
