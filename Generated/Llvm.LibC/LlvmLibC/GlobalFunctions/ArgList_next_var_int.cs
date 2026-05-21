using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArgList_next_var_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7ArgList8next_varIiEET_v")]
	[DemangledName("int __llvm_libc_20_1_2_::internal::ArgList::next_var<int>()")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_internal_ArgList* This)
	{
		unchecked
		{
			Va_list_tag* vlist = (Va_list_tag*)(&This->Vlist);
			int* gp_offset = &vlist->Gp_offset;
			int num = *gp_offset;
			nint num2;
			if ((uint)num <= 40u)
			{
				num2 = (nint)((byte*)vlist->Reg_save_area + num);
				*gp_offset = num + 8;
			}
			else
			{
				void** overflow_arg_area = &vlist->Overflow_arg_area;
				void* ptr = *overflow_arg_area;
				*overflow_arg_area = (byte*)ptr + 8;
				num2 = (nint)ptr;
			}
			return *(int*)num2;
		}
	}
}
